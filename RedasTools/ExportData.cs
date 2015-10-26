using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Microsoft.Office.Interop.Excel;
using Application=Microsoft.Office.Interop.Excel.Application;
using Excel=Microsoft.Office.Interop.Excel;
using Model;
using DataTable = System.Data.DataTable;
using System.Threading;

namespace RedasTools
{
    public partial class ExportData : Form
    {
        private DAL.ExportData exportData = new DAL.ExportData();
        private delegate void SetPos(double ipos); 
        public ExportData()
        {
            InitializeComponent();
        }

        public void ExportSurveryData()
        {
            double pos = 1;
            //创建Excel文件
            string filePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "\\长沙商业查勘数据.xlsx";
            if (!File.Exists(filePath))
            {
                Excel.Application excel = new Excel.Application(); //Execl的操作类
                Excel.Workbook bookDest = excel.Workbooks.Add(Missing.Value);
                excel.Application.Workbooks.Add(true);
                bookDest.SaveAs(filePath);
                excel.Quit();
                excel = null;

                GC.Collect();//垃圾回收
            }
            else
            {
                MessageBox.Show("已存在文件：" + filePath);
                return;
            }
            //table表头
            DataTable dt = new DataTable();
            dt.Columns.Add("标的物");
            //头部行的字段名称
            DataRow drHead = dt.NewRow();
            dt.Rows.InsertAt(drHead, 1);

            List<decimal> lstFormId = exportData.ExportSurveryData().Select(s => s.INSTANCE_ID).Distinct().ToList();
            
            foreach (var formId in lstFormId)
            {
                if (formId == 0)
                    continue;

                List<SurveryDataModel> lst = exportData.ExportSurveryData().Where(s => s.INSTANCE_ID == formId).ToList();


                FormViewModel formInstance = exportData.GetFormInstanceById((int)formId);
                
                //DataTable dt = new DataTable();
                //表头
                //dt.Columns.Add("标的物");

                foreach (var formLabelDTO in formInstance.LABLELIST)
                {
                    if (!dt.Columns.Contains(formLabelDTO.FORM_LABEL_ID.ToString()))
                    { 
                        dt.Columns.Add(formLabelDTO.FORM_LABEL_ID.ToString());
                        drHead[formLabelDTO.FORM_LABEL_ID.ToString()] = formInstance.LABLELIST.Where(f => f.FORM_LABEL_ID == Convert.ToDecimal(formLabelDTO.FORM_LABEL_ID)).FirstOrDefault().LABEL_NAME_CHS;
                    }
                }
                //数据
                foreach (var surveryDataModel in lst)
                {
                    DataRow dr = dt.NewRow();
                    List<LabelDataDTO> lstLabelData = JsonTools.JsonToObject2<List<LabelDataDTO>>(surveryDataModel.CONTENTS);

                    foreach (var labelDataDto in lstLabelData)
                    {
                        if (dt.Columns.Contains(labelDataDto.NAME))
                            dr[labelDataDto.NAME] = labelDataDto.VALUE;
                    }

                    dr["标的物"] = surveryDataModel.OBJECT_NAME;
                    dt.Rows.Add(dr);



                }
                
               
               
                //DoExport(dt,filePath, formId.ToString());
                //bool flag= DoExport(dt);
                //SetTextMessage(pos/lstFormId.Count);
                //pos++;

                //richTextBox1.Text += "表单ID：" + formId + " 数据导出完成.\n";
            }
            DoExport(dt, filePath, "长沙商业查勘");
            MessageBox.Show("导出成功！");
            //progressBar1.Value = 100;

            //头部信息
            //DataRow drHead = dt.NewRow();
            //foreach (DataColumn dc in dt.Columns)
            //{
            //    if (dc.ColumnName != "标的物")
            //    {
            //        drHead[dc.Caption] =
            //            formInstance.LABLELIST.Where(f => f.FORM_LABEL_ID == Convert.ToDecimal(dc.Caption)).FirstOrDefault().LABEL_NAME_CHS;
            //    }
            //    else
            //    {
            //        drHead[dc.Caption] = "标的物";
            //    }

            //}
            //dt.Rows.InsertAt(drHead, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportSurveryData();
            //Thread fThread = new Thread(new ThreadStart(ExportSurveryData));//开辟一个新的线程

            //fThread.Start();
        }

        /// <summary>
        /// DataTable直接导出Excel,此方法会把DataTable的数据用Excel打开,再自己手动去保存到确切的位置
        /// </summary>
        /// <param name="dt">要导出Excel的DataTable</param>
        /// <returns></returns>
        public bool DoExport(DataTable dt)
        {
           Application app = new ApplicationClass();
            if (app == null)
            {
                throw new Exception("Excel无法启动");
            }
            app.Visible = true;
            Workbooks wbs = app.Workbooks;
            Workbook wb = wbs.Add(Missing.Value);
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            int cnt = dt.Rows.Count;
            int columncnt = dt.Columns.Count;

            // *****************获取数据********************
            object[,] objData = new Object[cnt + 1, columncnt];  // 创建缓存数据
            // 获取列标题
            //for (int i = 0; i < columncnt; i++)
            //{
            //    objData[0, i] = dt.Columns[i].ColumnName;
            //}
            // 获取具体数据
            for (int i = 0; i < cnt; i++)
            {
                System.Data.DataRow dr = dt.Rows[i];
                for (int j = 0; j < columncnt; j++)
                {
                    objData[i + 1, j] = dr[j];
                }
            }

            //********************* 写入Excel******************
            Range r = ws.get_Range(app.Cells[1, 1], app.Cells[cnt + 1, columncnt]);
            r.NumberFormat = "@";
            //r = r.get_Resize(cnt+1, columncnt);
            r.Value2 = objData;
            r.EntireColumn.AutoFit();

            app = null;
            return true;
        }

        private void DoExport(DataTable dt, string toFileName, string strSheetName)
        {

            Excel.Application excel = new Excel.Application(); //Execl的操作类
            //读取保存目标的对象
            Excel.Workbook bookDest = excel.Workbooks._Open(toFileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value
            , Missing.Value, Missing.Value, Missing.Value, Missing.Value
            , Missing.Value, Missing.Value, Missing.Value, Missing.Value);//打开要导出到的Execl文件的工作薄。--ps:关于Missing类在这里的作用，我也不知道...囧
            Excel.Worksheet sheetDest = bookDest.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value) as Excel.Worksheet;//给工作薄添加一个Sheet

            sheetDest.Name = strSheetName;//自己定义名字O(∩_∩)O哈哈~

            int rowIndex = 1;
            int colIndex = 0;

            excel.Application.Workbooks.Add(true);//这句不写不知道会不会报错

            //foreach (DataColumn col in dt.Columns)
            //{
            //    colIndex++;
            //    sheetDest.Cells[1, colIndex] = col.ColumnName;//Execl中的第一列,把DataTable的列名先导进去
            //}

            //导入数据行
            foreach (DataRow row in dt.Rows)
            {
                rowIndex++;
                colIndex = 0;
                foreach (DataColumn col in dt.Columns)
                {
                    colIndex++;
                    sheetDest.Cells[rowIndex, colIndex] = row[col.ColumnName].ToString();
                }
            }

            bookDest.Saved = true;
            
            bookDest.Save();
            excel.Quit();
            excel = null;

            GC.Collect();//垃圾回收
        }

         private void SetTextMessage(double ipos)

         {

            if (this.InvokeRequired)

             {

                 SetPos setpos = new SetPos(SetTextMessage);

                this.Invoke(setpos, new object[] { ipos});

             }

            else

             {

                //this.label1.Text = ipos.ToString() + "/100";

                this.progressBar1.Value = Convert.ToInt32(ipos*100);
                 
             }

         }
    }
}
