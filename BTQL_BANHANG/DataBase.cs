using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BTQL_BANHANG
{

    public class DataBase
    {
        SqlConnection sqlconn = null;
        string strconn = "server = ADMIN; database = c#QL_BanHang; uid = Duy; pwd = 12345";
        DataSet ds = null;
        public void ConnectSQL()
        {
            try
            {
                if (sqlconn == null) sqlconn = new SqlConnection(strconn);
                if (sqlconn.State == ConnectionState.Closed) sqlconn.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet GetDataSet(string query)
        {
            ConnectSQL();
            SqlCommand cmd = new SqlCommand(query,sqlconn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public void SetData(string query)
        {
            ConnectSQL();
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            cmd.ExecuteNonQuery();
        }
        public void SetData(string query,int masp)
        {
            ConnectSQL();
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.ExecuteNonQuery();
        }
        public void ThemSP(string query, string ten, int sl, float gia, DateTime ngaynhap, int madm, int makho)
        {
            ConnectSQL();
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            cmd.Parameters.AddWithValue("@ten", ten);
            cmd.Parameters.AddWithValue("@sl", sl);
            cmd.Parameters.AddWithValue("@gia", gia);
            cmd.Parameters.AddWithValue("@ngaynhap", ngaynhap);
            cmd.Parameters.AddWithValue("@madm", madm);
            cmd.Parameters.AddWithValue("@makho", makho);
            cmd.ExecuteNonQuery();
            
        }

        //end uc NhapHang

        //Load SP Theo DM len list Box trong UC_XuatHang
        public DataSet GetDataSet(string query, int madm)
        {
            ConnectSQL();
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            cmd.Parameters.AddWithValue("@madm", madm);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        public DataSet GetDataSet(string query, string tensp)
        {
            ConnectSQL();
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            cmd.Parameters.AddWithValue("@ten", tensp);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        public DataSet LaySPTheoDM(string query, int madm)
        {
            ConnectSQL();
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            cmd.Parameters.AddWithValue("@madm", madm);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        
        public DataSet TimKiemSP_UCXuatHang(string query,string tensp)
        {
            ConnectSQL();
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            cmd.Parameters.AddWithValue("@tensp", "%"+tensp+"%");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        //end

    }
}
