using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;

namespace DAL
{
    public class ExportData
    {
        public List<SurveryDataModel> ExportSurveryData()
        {
            using (var db = new RedasDBHelper())
            {
                var dic = new Dictionary<string, object>();

                dic.Add("cur_result", null);

                var field = new RedasDbFieldDTO();
                IList<SurveryDataModel> fieldList = db.ExecuteListProc<SurveryDataModel>("pkg_Test.sp_SurveryData_get", dic);

                return fieldList.ToList();
            }
        }

        public IList<RedasDbFieldDTO> GetDbField(int tableId)
        {


            using (EGJDBHelper db = new EGJDBHelper())
            {
                var dic = new Dictionary<string, object>();
                dic["i_table_id"] = tableId;
                dic.Add("cur_result", null);
                IList<RedasDbFieldDTO> fields = db.ExecuteListProc<RedasDbFieldDTO>("pkg_city_config.sp_get_db_field", dic);
                if (fields != null && fields.Count > 0)
                {
                    return fields;
                }
                return null;
            }
        }

        //根据实例Id获取表单实例
        public FormViewModel GetFormInstanceById(int InstanceId)
        {
            FormViewModel formInstance = new FormViewModel();
            Dictionary<string, object> dsDic = new Dictionary<string, object>();
            dsDic.Add("i_InstanceId", InstanceId);
            using (BaseDB db = new RedasDBHelper())
            {
                try
                {
                    IList<FormViewModel> InstanceList = db.ExecuteListProc<FormViewModel>("pkg_Test.sp_get_instanceform", dsDic);
                    if (InstanceList != null && InstanceList.Count > 0)
                    {
                        formInstance = InstanceList[0];
                       formInstance.LABLELIST = JsonTools.JsonToObject2<DFormViewModel>(formInstance.CONTENTS).FormLabels
                            .Where(l => l.IsSelected == true)
                            .OrderBy(d => d.DEFAULT_ORDER).ThenBy(d => d.SORT).ToList();
                    }
                }
                catch
                {
                    formInstance = new FormViewModel();
                }
            }
            return formInstance;
        }

       
    }
}
