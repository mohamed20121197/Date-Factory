using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Date_factory.BL
{
    class vendors
    {
        public void add_vendor(string ven_name, string ven_phone, string ven_address,
            double last_money, double ven_credit_limit, string ven_type,
            string notes, byte[] ven_image)

        {

            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter  [] param =new SqlParameter [8];


            param[0] = new SqlParameter("@ven_name", SqlDbType.VarChar, 50);
            param[0].Value = ven_name;

            param[1] = new SqlParameter("@ven_phone", SqlDbType.VarChar, 50);
            param[1].Value = ven_phone;

            param[2] = new SqlParameter("@ven_address", SqlDbType.VarChar, 50);
            param[2].Value = ven_address;

            param[3] = new SqlParameter("@last_money", SqlDbType.Float);
            param[3].Value = last_money;

            param[4] = new SqlParameter("@ven_credit_limit", SqlDbType.Float);
            param[4].Value = ven_credit_limit;

            param[5] = new SqlParameter("@ven_type", SqlDbType.VarChar, 50);
            param[5].Value = ven_type;


            param[6] = new SqlParameter("@notes", SqlDbType.VarChar, 50);
            param[6].Value = notes;


            param[7] = new SqlParameter("@ven_image", SqlDbType.Image);
            param[7].Value = ven_image;

            dal.ExecuteComand("add_vendor", param);
                

            dal.close();
        
        
        
        
        
        }



        public DataTable get_all_vendors()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt=  dal.selectData("get_all_vendors", null);
            dal.close();
            return dt;

        
     }


        public DataTable get_last_ven_id()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("get_last_ven_id", null);
            dal.close();
            return dt;


        }
    }
}
