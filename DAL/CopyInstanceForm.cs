using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace DAL
{
   public class CopyInstanceForm
    {
       public BaseResult CopyForm(string CustomerId, string UserId, string FormId)
       {

           BaseResult result = new BaseResult();
           try
           {
               using (RedasDBHelper db = new RedasDBHelper())
               {
                   var dic = new Dictionary<string, object>();
                   dic["i_customer_id"] = CustomerId;
                   dic["i_user_id"] = UserId;
                   dic["i_form_id"] = FormId;

                     db.ExecuteNonQueryProc("pkg_test_tools.sp_copy_forminstance", dic);
                     db.Commit();
                     result.Succeeded = true;
                   
               }
           }
           catch (Exception ex)
           {

               result.Succeeded = false;
               result.Error = ex.Message;
           }
           return result;
       }
       //根据登录帐号获取用户信息
       public UserDTO GetUserByLoginId(string loginId)
       {
           using (BaseDB db = new OmpdDBHelper())
           {
               UserDTO user=new UserDTO();
               Dictionary<string, object> dic = new Dictionary<string, object>();
               dic.Add("i_LOGIN_ID", loginId);
               var userDtos = db.ExecuteListProc<UserDTO>("pkg_user.sp_user_get", dic);
               if (userDtos != null && userDtos.Count > 0)
                   user = userDtos[0];
               return user;
           }
       }
    }
}
