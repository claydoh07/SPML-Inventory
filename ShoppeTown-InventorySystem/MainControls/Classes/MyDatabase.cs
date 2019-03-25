using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppeTown_InventorySystem.Properties;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace ShoppeTown_InventorySystem
{
    class MyDatabase
    {
        //connection to my database
        MySqlConnection con = new MySqlConnection("server=" + Settings.Default["Server"].ToString()
            + "; username=" + Settings.Default["UsernameDB"].ToString()
            + "; password=" + Settings.Default["PasswordDB"].ToString()
            + "; database=" + Settings.Default["DatabaseName"].ToString()
            + "; port=" + Settings.Default["Port"].ToString() + ";");

        public string TestLogin(string usr, string pwd)
        {
            string usersResult = "";
            try
            {
                con.Open();
                string SqlSelectUsers = "SELECT * FROM tbl_users WHERE username=@u AND password=@p;";
                MySqlCommand com = new MySqlCommand(SqlSelectUsers, con);
                com.Parameters.AddWithValue("@u", usr);
                com.Parameters.AddWithValue("@p", pwd);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    AccountInfo.id = dr["user_id"].ToString();
                    usersResult = "PASSED";
                }
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                con.Close();
            }
            return usersResult;
        }
        /*---------- register ----------*/
        public string TestRegister(string usr, string pwd)
        {
            string checkUsers = "";
            try
            {
                con.Open();
                string SqlSelectUsers = "SELECT * FROM tbl_users WHERE username=@u AND password=@p;";
                MySqlCommand com = new MySqlCommand(SqlSelectUsers, con);
                com.Parameters.AddWithValue("@u", usr);
                com.Parameters.AddWithValue("@p", pwd);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    checkUsers = "EXISTING";
                }
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                con.Close();
            }
            return checkUsers;
        }
        //Insert password and username
        public string Register(string usr, string pwd)
        {
             try
            {
                con.Open();
                string SqlInsertRegister = "INSERT INTO tbl_users(" +
                    "username, password, firstName, middleName, lastName, " +
                    "userType, position, department, created_at, updated_at) " +
                    "VALUES(@username, @password, @fname, @mname, @lname, " +
                    "@usertype, @position, @department, @created_at, @updated_at);";
                MySqlCommand com = new MySqlCommand(SqlInsertRegister, con);
                com.Parameters.AddWithValue("@username", usr);
                com.Parameters.AddWithValue("@password", pwd);
                com.Parameters.AddWithValue("@fname", RegisterAutoProperty.fname);
                com.Parameters.AddWithValue("@mname", RegisterAutoProperty.mname);
                com.Parameters.AddWithValue("@lname", RegisterAutoProperty.lname);
                com.Parameters.AddWithValue("@usertype", RegisterAutoProperty.usertype);
                com.Parameters.AddWithValue("@position", RegisterAutoProperty.position);
                com.Parameters.AddWithValue("@department", RegisterAutoProperty.department);
                
                com.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"));
                com.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"));
                com.ExecuteNonQuery();
                //  YYYY-MM-DD HH:MM:SS
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }
        public DataGridView dgv_SearchInventory(string search)
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "" +
              "select fasm_code as 'ITEM CODE', fasm_category as 'CATEGORY', " +
              "fasm_subcat as 'SUB CAT', fasm_item as ITEM, fasm_desc as DESCRIPTION," +
              "fasm_brand as BRAND, fasm_model as MODEL from tbl_fasm " +
              "where fasm_code like '%" + search + "%' or " +
                "      fasm_category like '%" + search + "%' or " +
                "      fasm_subcat like '%" + search + "%' or " +
                "      fasm_item like '%" + search + "%' or " +
                "      fasm_desc like '%" + search + "%' or " +
                "      fasm_brand like '%" + search + "%' or " +
                "      fasm_model like '%" + search + "%';";
                
                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_SearchSections");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }
        public DataGridView dgvFASM(string search)
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "" +
              "select * from tbl_fasm " +
              "where fasm_code like '%" + search + "%' or " +
                "      fasm_category like '%" + search + "%' or " +
                "      fasm_subcat like '%" + search + "%' or " +
                "      fasm_item like '%" + search + "%' or " +
                "      fasm_desc like '%" + search + "%' or " +
                "      fasm_brand like '%" + search + "%' or " +
                "      fasm_model like '%" + search + "%' or " +
                "      fasm_po like '%" + search + "%' or " +
                "      fasm_wpo like '%" + search + "%' or " +
                "      fasm_issued like '%" + search + "%' or " +
                "      fasm_returned like '%" + search + "%' or " +
                "      fasm_transferred like '%" + search + "%' or " +
                "      fasm_damaged like '%" + search + "%' or " +
                "      fasm_stocks like '%" + search + "%';";
                
                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_SearchSections");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        public DataGridView dgv_showItemCode()
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = @"SELECT `id`,
                            `itemCode`,
                            `itemCode_Category`,
                            `itemCode_SubCategory`,
                            `itemCode_ItemName`,
                            `itemCode_Brand`,
                            `itemCode_Model`,
                            `itemCode_Description` FROM tbl_itemcode;";

                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_SearchSections");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        public DataGridView dgvUnissued(string search)
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "" +
              "select * from tbl_fasm " +
              "where fasm_stocks >= 1;";

                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_SearchSections");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }
        //Vendor Codes
        public string AddVendor(string cat1, string subcat1, string cat2, string subcat2, string cat3, string subcat3,
            string cat4, string subcat4, string cat5, string subcat5, string cat6, string subcat6, string cat7, string subcat7,
            string compname, string contactperson, string compaddress, 
            string tel1, string tel2,
            string mob1, string mob2, 
            string fax, string emailadd1, string emailadd2, 
            string website)
        {
            try
            {
                con.Open();
                string SqlInsertVendor = "INSERT INTO tbl_vendor(" +
                    "vendor_category1, vendor_subcategory1," +
                    "vendor_category2, vendor_subcategory2," +
                    "vendor_category3, vendor_subcategory3," +
                    "vendor_category4, vendor_subcategory4," +
                    "vendor_category5, vendor_subcategory5," +
                    "vendor_category6, vendor_subcategory6," +
                    "vendor_category7, vendor_subcategory7, vendor_name, " +
                    "vendor_contactperson, vendor_address, vendor_telephone1, " +
                    "vendor_telephone2, vendor_mobile1, vendor_mobile2, " +
                    "vendor_fax, vendor_emailadd1, vendor_emailadd2, vendor_website, " +
                    "created_at, updated_at) " +
                    "VALUES (@category1, @subcat1, " +
                    "        @category2, @subcat2, " +
                    "        @category3, @subcat3, " +
                    "        @category4, @subcat4, " +
                    "        @category5, @subcat5, " +
                    "        @category6, @subcat6, " +
                    "        @category7, @subcat7, @vendorname, " +
                    "        @contactperson, @vendoraddress, @vendortel1, " +
                    "        @vendortel2, @vendormob1, @vendormob2, " +
                    "        @vendorfax, @vendoremail1, @vendoremail2, @vendorwebsite, " +
                    "        @created_at, @updated_at);";

                MySqlCommand com = new MySqlCommand(SqlInsertVendor, con);
                com.Parameters.AddWithValue("@category1", cat1);
                com.Parameters.AddWithValue("@subcat1", subcat1);
                com.Parameters.AddWithValue("@category2", cat2);
                com.Parameters.AddWithValue("@subcat2", subcat2);
                com.Parameters.AddWithValue("@category3", cat3);
                com.Parameters.AddWithValue("@subcat3", subcat3);
                com.Parameters.AddWithValue("@category4", cat4);
                com.Parameters.AddWithValue("@subcat4", subcat4);
                com.Parameters.AddWithValue("@category5", cat5);
                com.Parameters.AddWithValue("@subcat5", subcat5);
                com.Parameters.AddWithValue("@category6", cat6);
                com.Parameters.AddWithValue("@subcat6", subcat6);
                com.Parameters.AddWithValue("@category7", cat7);
                com.Parameters.AddWithValue("@subcat7", subcat7);
                com.Parameters.AddWithValue("@vendorname", compname);
                com.Parameters.AddWithValue("@contactperson", contactperson);
                com.Parameters.AddWithValue("@vendoraddress", compaddress);
                com.Parameters.AddWithValue("@vendortel1", tel1);
                com.Parameters.AddWithValue("@vendortel2", tel2);
                com.Parameters.AddWithValue("@vendormob1", mob1);
                com.Parameters.AddWithValue("@vendormob2", mob2);
                com.Parameters.AddWithValue("@vendorfax", fax);
                com.Parameters.AddWithValue("@vendoremail1", emailadd1);
                com.Parameters.AddWithValue("@vendoremail2", emailadd2);
                com.Parameters.AddWithValue("@vendorwebsite", website);
                com.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"));
                com.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"));
                com.ExecuteNonQuery();
                //  YYYY-MM-DD HH:MM:SS
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public string UpdateVendor(string cat1, string subcat1, string cat2, string subcat2, string cat3, string subcat3,
            string cat4, string subcat4, string cat5, string subcat5, string cat6, string subcat6, string cat7, string subcat7,
            string compname, string contactperson, string compaddress,
            string tel1, string tel2,
            string mob1, string mob2,
            string fax, string emailadd1, string emailadd2,
            string website)
        {
            try
            {
                con.Open();
                /*string SqlInsertVendor = "INSERT INTO tbl_vendor(" +
                    "vendor_category, vendor_subcategory, vendor_name, " +
                    "vendor_contactperson, vendor_address, vendor_telephone1, " +
                    "vendor_telephone2, vendor_mobile1, vendor_mobile2, " +
                    "vendor_fax, vendor_emailadd1, vendor_emailadd2, vendor_website, " +
                    "created_at, updated_at) " +
                    "VALUES (@category, @subcat, @vendorname, " +
                    "        @contactperson, @vendoraddress, @vendortel1, " +
                    "        @vendortel2, @vendormob1, @vendormob2, " +
                    "        @vendorfax, @vendoremail1, @vendoremail2, @vendorwebsite, " +
                    "        @created_at, @updated_at);";*/

                string SqlUpdateVendor = "UPDATE tbl_vendor " +
                "SET vendor_category1 = @category1, vendor_subcategory1 = @subcat1," +
                    "vendor_category2 = @category2, vendor_subcategory2 = @subcat2," +
                    "vendor_category3 = @category3, vendor_subcategory3 = @subcat3," +
                    "vendor_category4 = @category4, vendor_subcategory4 = @subcat4," +
                    "vendor_category5 = @category5, vendor_subcategory5 = @subcat5," +
                    "vendor_category6 = @category6, vendor_subcategory6 = @subcat6," +
                    "vendor_category7 = @category7, vendor_subcategory7 = @subcat7," +
                    "vendor_name = @vendorname, vendor_contactperson = @contactperson," +
                    "vendor_address = @vendoraddress, vendor_telephone1 = @vendortel1," +
                    "vendor_telephone2 = @vendortel2, vendor_mobile1 = @vendormob1," +
                    "vendor_mobile2 = @vendormob2, vendor_fax = @vendorfax," +
                    "vendor_emailadd1 = @vendoremail1, vendor_emailadd2 = @vendoremail2," +
                    "vendor_website = @vendorwebsite, updated_at = @updated_at" +
                    " Where vendor_id = @id;";

                MySqlCommand com = new MySqlCommand(SqlUpdateVendor, con);
                com.Parameters.AddWithValue("@category1", cat1);
                com.Parameters.AddWithValue("@subcat1", subcat1);
                com.Parameters.AddWithValue("@category2", cat2);
                com.Parameters.AddWithValue("@subcat2", subcat2);
                com.Parameters.AddWithValue("@category3", cat3);
                com.Parameters.AddWithValue("@subcat3", subcat3);
                com.Parameters.AddWithValue("@category4", cat4);
                com.Parameters.AddWithValue("@subcat4", subcat4);
                com.Parameters.AddWithValue("@category5", cat5);
                com.Parameters.AddWithValue("@subcat5", subcat5);
                com.Parameters.AddWithValue("@category6", cat6);
                com.Parameters.AddWithValue("@subcat6", subcat6);
                com.Parameters.AddWithValue("@category7", cat7);
                com.Parameters.AddWithValue("@subcat7", subcat7);
                com.Parameters.AddWithValue("@vendorname", compname);
                com.Parameters.AddWithValue("@contactperson", contactperson);
                com.Parameters.AddWithValue("@vendoraddress", compaddress);
                com.Parameters.AddWithValue("@vendortel1", tel1);
                com.Parameters.AddWithValue("@vendortel2", tel2);
                com.Parameters.AddWithValue("@vendormob1", mob1);
                com.Parameters.AddWithValue("@vendormob2", mob2);
                com.Parameters.AddWithValue("@vendorfax", fax);
                com.Parameters.AddWithValue("@vendoremail1", emailadd1);
                com.Parameters.AddWithValue("@vendoremail2", emailadd2);
                com.Parameters.AddWithValue("@vendorwebsite", website);
                com.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"));
                com.Parameters.AddWithValue("@id", RegisterAutoProperty.vendorID);
                com.ExecuteNonQuery();
                //  YYYY-MM-DD HH:MM:SS
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public string DeleteVendor(string cat1, string subcat1, string cat2, string subcat2, string cat3, string subcat3,
            string cat4, string subcat4, string cat5, string subcat5, string cat6, string subcat6, string cat7, string subcat7,
            string compname, string contactperson, string compaddress,
            string tel1, string tel2,
            string mob1, string mob2,
            string fax, string emailadd1, string emailadd2,
            string website)
        {
            try
            {
                con.Open();
               

                string SqlDeleteVendor = "DELETE FROM tbl_vendor" +
                    " Where vendor_id = @id;";

                MySqlCommand com = new MySqlCommand(SqlDeleteVendor, con);
                com.Parameters.AddWithValue("@id", RegisterAutoProperty.vendorID);
                com.ExecuteNonQuery();
                //  YYYY-MM-DD HH:MM:SS
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public DataGridView dgv_VendorTable(string search)
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "" +
              @"select `tbl_vendor`.`vendor_id`,
                `tbl_vendor`.`vendor_name`,
                `tbl_vendor`.`vendor_contactperson`,
                `tbl_vendor`.`vendor_address`,
                `tbl_vendor`.`vendor_telephone1`,
                `tbl_vendor`.`vendor_telephone2`,
                `tbl_vendor`.`vendor_mobile1`,
                `tbl_vendor`.`vendor_mobile2`,
                `tbl_vendor`.`vendor_fax`,
                `tbl_vendor`.`vendor_emailadd1`,
                `tbl_vendor`.`vendor_emailadd2`,
                `tbl_vendor`.`vendor_website`,
                `tbl_vendor`.`vendor_category1`,
                `tbl_vendor`.`vendor_subcategory1`,
                `tbl_vendor`.`vendor_category2`,
                `tbl_vendor`.`vendor_subcategory2`,
                `tbl_vendor`.`vendor_category3`,
                `tbl_vendor`.`vendor_subcategory3`,
                `tbl_vendor`.`vendor_category4`,
                `tbl_vendor`.`vendor_subcategory4`,
                `tbl_vendor`.`vendor_category5`,
                `tbl_vendor`.`vendor_subcategory5`,
                `tbl_vendor`.`vendor_category6`,
                `tbl_vendor`.`vendor_subcategory6`,
                `tbl_vendor`.`vendor_category7`,
                `tbl_vendor`.`vendor_subcategory7` from tbl_vendor " +
              "where vendor_category1 like '%" + search + "%' or " +
              "      vendor_subcategory1 like '%" + search + "%' or " +
              "      vendor_category2 like '%" + search + "%' or " +
              "      vendor_subcategory2 like '%" + search + "%' or " +
              "      vendor_category3 like '%" + search + "%' or " +
              "      vendor_subcategory3 like '%" + search + "%' or " +
              "      vendor_category4 like '%" + search + "%' or " +
              "      vendor_subcategory4 like '%" + search + "%' or " +
              "      vendor_category5 like '%" + search + "%' or " +
              "      vendor_subcategory5 like '%" + search + "%' or " +
              "      vendor_category6 like '%" + search + "%' or " +
              "      vendor_subcategory6 like '%" + search + "%' or " +
              "      vendor_category7 like '%" + search + "%' or " +
              "      vendor_subcategory7 like '%" + search + "%' or " +

              "      vendor_name like '%" + search + "%' or " +
              "      vendor_contactperson like '%" + search + "%' or " +
              "      vendor_address like '%" + search + "%' or " +
              "      vendor_telephone1 like '%" + search + "%' or " +
              "      vendor_telephone2 like '%" + search + "%' or " +
              "      vendor_mobile1 like '%" + search + "%' or " +
              "      vendor_mobile2 like '%" + search + "%' or " +
              "      vendor_fax like '%" + search + "%' or " +
              "      vendor_emailadd1 like '%" + search + "%' or " +
              "      vendor_emailadd2 like '%" + search + "%' or " +
              "      vendor_website like '%" + search + "%';";





                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_SearchSections");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        //=========================register item code================
        public string[] showCategory()
        {
            string[] cont = new string[100];
            for (int x = 0; x < 100; x++)
                cont[x] = "";

            int num = 0;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_category";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    cont[num++] = dr1["category_Name"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "select Category");
            }
            finally
            {
                con.Close();
            }
            return cont;
        }

        public string sCode(string categoryName)
        {
            string code = "";
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_category WHERE category_Name = @cN";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", categoryName);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    code = dr1["category_Code"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "sCode");
            }
            finally
            {
                con.Close();
            }
            return code;
        }

        public string sSubCat(string cat, string code, string sub)
        {
            string num = "";
            try
            {
                con.Open();
                string sql = "SELECT a.subCategory_Number FROM tbl_subcategory a, tbl_category b WHERE a.category_id = b.category_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", sub);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    num = dr1["subCategory_Number"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "sSubCat");
            }
            finally
            {
                con.Close();
            }
            return num;
        }

        public string sItem(string cat, string code, string sub, string item)
        {
            string num = "";
            try
            {
                con.Open();
                string sql = "SELECT c.item_Number FROM tbl_subcategory a, tbl_category b, tbl_item c WHERE a.category_id = b.category_id AND a.subCategory_id = c.subCategory_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN AND c.item_Name = @iN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", sub);
                com.Parameters.AddWithValue("@iN", item);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    num = dr1["item_number"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "sItem");
            }
            finally
            {
                con.Close();
            }
            return num;
        }

        public string sBrand(string cat, string code, string sub, string item, string brand)
        {
            string num = "";
            try
            {
                con.Open();
                string sql = "SELECT d.brand_Number FROM tbl_subcategory a, tbl_category b, tbl_item c, tbl_brand d WHERE a.category_id = b.category_id AND a.subCategory_id = c.subCategory_id AND c.item_id = d.item_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN AND c.item_Name = @iN AND d.brand_Name = @bN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", sub);
                com.Parameters.AddWithValue("@iN", item);
                com.Parameters.AddWithValue("@bN", brand);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    num = dr1["brand_Number"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "sBrand");
            }
            finally
            {
                con.Close();
            }
            return num;
        }

        public string sModel(string cat, string code, string sub, string item, string brand, string model)
        {
            string num = "";
            try
            {
                con.Open();
                string sql = "SELECT e.model_Number FROM tbl_subcategory a, tbl_category b, tbl_item c, tbl_brand d, tbl_model e WHERE a.category_id = b.category_id AND a.subCategory_id = c.subCategory_id AND c.item_id = d.item_id AND d.brand_id = e.brand_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN AND c.item_Name = @iN AND d.brand_Name = @bN ANd e.model_Name = @eN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", sub);
                com.Parameters.AddWithValue("@iN", item);
                com.Parameters.AddWithValue("@bN", brand);
                com.Parameters.AddWithValue("@eN", model);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    num = dr1["model_Number"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "sModel");
            }
            finally
            {
                con.Close();
            }
            return num;
        }

        public string sDescription(string cat, string code, string sub, string item, string brand, string model, string description)
        {
            string num = "";
            try
            {
                con.Open();
                string sql = "SELECT f.description_Number FROM tbl_subcategory a, tbl_category b, tbl_item c, tbl_brand d, tbl_model e, tbl_description f WHERE a.category_id = b.category_id AND a.subCategory_id = c.subCategory_id AND c.item_id = d.item_id AND d.brand_id = e.brand_id AND e.model_id = f.model_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN AND c.item_Name = @iN AND d.brand_Name = @bN ANd e.model_Name = @eN AND f.description_Name = @dN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", sub);
                com.Parameters.AddWithValue("@iN", item);
                com.Parameters.AddWithValue("@bN", brand);
                com.Parameters.AddWithValue("@eN", model);
                com.Parameters.AddWithValue("@dN", description);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    num = dr1["description_Number"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "sDescription");
            }
            finally
            {
                con.Close();
            }
            return num;
        }

        public string[] ShowSubCategory(string cat, string code)
        {
            string[] cont = new string[100];
            for (int x = 0; x < 100; x++)
                cont[x] = "";

            int num = 0;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_subcategory a, tbl_category b WHERE a.category_id = b.category_id AND b.category_Name = @cN AND b.category_Code = @cC ;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    cont[num++] = dr1["subCategory_Name"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "select SubCategory");
            }
            finally
            {
                con.Close();
            }
            return cont;
        }

        public string[] ShowItems(string cat, string code, string sub)
        {
            string[] cont = new string[200];
            for (int x = 0; x < 200; x++)
                cont[x] = "";

            int num = 0;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_subcategory a, tbl_category b, tbl_item c WHERE a.category_id = b.category_id AND a.subCategory_id = c.subCategory_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", sub);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    cont[num++] = dr1["item_Name"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "ShowItems");
            }
            finally
            {
                con.Close();
            }
            return cont;
        }

        public string[] ShowBrand(string cat, string code, string sub, string item)
        {
            string[] cont = new string[200];
            for (int x = 0; x < 200; x++)
                cont[x] = "";

            int num = 0;
            try
            {
                con.Open();
                string sql = "SELECT d.brand_Name FROM tbl_subcategory a, tbl_category b, tbl_item c, tbl_brand d WHERE a.category_id = b.category_id AND a.subCategory_id = c.subCategory_id AND c.item_id = d.item_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN AND c.item_Name = @iN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", sub);
                com.Parameters.AddWithValue("@iN", item);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    cont[num++] = dr1["brand_Name"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "ShowBrand");
            }
            finally
            {
                con.Close();
            }
            return cont;
        }

        public string[] ShowModel(string cat, string code, string sub, string item, string brand)
        {
            string[] cont = new string[200];
            for (int x = 0; x < 200; x++)
                cont[x] = "";

            int num = 0;
            try
            {
                con.Open();
                string sql = "SELECT e.model_Name FROM tbl_subcategory a, tbl_category b, tbl_item c, tbl_brand d, tbl_model e WHERE a.category_id = b.category_id AND a.subCategory_id = c.subCategory_id AND c.item_id = d.item_id AND d.brand_id = e.brand_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN AND c.item_Name = @iN AND d.brand_Name = @bN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", sub);
                com.Parameters.AddWithValue("@iN", item);
                com.Parameters.AddWithValue("@bN", brand);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    cont[num++] = dr1["model_Name"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "ShowModel");
            }
            finally
            {
                con.Close();
            }
            return cont;
        }

        public string[] ShowDescription(string cat, string code, string sub, string item, string brand, string model)
        {
            string[] cont = new string[200];
            for (int x = 0; x < 200; x++)
                cont[x] = "";

            int num = 0;
            try
            {
                con.Open();
                string sql = "SELECT f.description_Name FROM tbl_subcategory a, tbl_category b, tbl_item c, tbl_brand d, tbl_model e, tbl_description f WHERE a.category_id = b.category_id AND a.subCategory_id = c.subCategory_id AND c.item_id = d.item_id AND d.brand_id = e.brand_id AND e.model_id = f.model_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN AND c.item_Name = @iN AND d.brand_Name = @bN AND e.model_Name = @mN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", sub);
                com.Parameters.AddWithValue("@iN", item);
                com.Parameters.AddWithValue("@bN", brand);
                com.Parameters.AddWithValue("@mN", model);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    cont[num++] = dr1["description_Name"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "ShowDescription");
            }
            finally
            {
                con.Close();
            }
            return cont;
        }

        public void RegisterItemCode(string itemCode, string category, string subcat, string items, string brand, string model, string description)
        {
            try
            {
                con.Open();
                string sql1 = "INSERT INTO tbl_itemcode(`itemCode`,`itemCode_Category`,`itemCode_SubCategory`,`itemCode_ItemName`,`itemCode_Brand`,`itemCode_Model`,`itemCode_Description`, `created_at`, `updated_at`) VALUES(@itemCode, @cat, @subCat, @item, @brand, @mod, @desc, @date1, @date2);";//inserting itemcode
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@itemCode", itemCode);
                com1.Parameters.AddWithValue("@cat", category);
                com1.Parameters.AddWithValue("@subCat", subcat);
                com1.Parameters.AddWithValue("@item", items);
                com1.Parameters.AddWithValue("@brand", brand);
                com1.Parameters.AddWithValue("@mod", model);
                com1.Parameters.AddWithValue("@desc", description);
                com1.Parameters.AddWithValue("@date1", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                com1.Parameters.AddWithValue("@date2", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                com1.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Created Successful", "Save!");
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "RegisterItemCode");
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertCategory(string category, string code)//cat1
        {
            try
            {
                con.Open();
                string sql1 = "INSERT INTO tbl_category(`category_Name`,`category_Code`) VALUES(@cN, @cC);";//inserting category
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@cN", category);
                com1.Parameters.AddWithValue("@cC", code);
                com1.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Created Successful", "Save!");
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "Insert Category");
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertSubCategory(string cat, string code, string subName)
        {
            int count = 0;
            string id = "";
            try
            {
                //kukunin yung id ng category
                con.Open();
                string sql2 = "SELECT category_id FROM tbl_category WHERE category_Name = @cN AND category_Code = @cC;";
                MySqlCommand com2 = new MySqlCommand(sql2, con);
                com2.Parameters.AddWithValue("@cN", cat);
                com2.Parameters.AddWithValue("@cC", code);
                com2.ExecuteNonQuery();

                MySqlDataReader dr2 = com2.ExecuteReader();
                while (dr2.Read())
                {
                    id = dr2["category_id"].ToString();
                }
                con.Close();

                //kukunin yung bilang ng mga subcategory per category
                con.Open();
                string sql = "SELECT b.category_id FROM tbl_subcategory a, tbl_category b WHERE a.category_id = b.category_id AND b.category_Name = @cN AND b.category_Code = @cC;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    count++;
                }
                con.Close();

                //<-----inserting ng new subcategory----->
                con.Open();
                string sql1 = "INSERT INTO tbl_subcategory(`subCategory_Name`,`subCategory_Number`, `category_id`) VALUES(@sN, @sNum, @id);";//inserting sub-category
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@sN", subName);
                com1.Parameters.AddWithValue("@sNum", ++count);
                com1.Parameters.AddWithValue("@id", id);
                com1.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Created Successful", "Save!");
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message + "b" + count + "a" + id, "Insert SUBCategory");
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertItemName(string cat, string code, string subName, string item)
        {
            int count = 0;
            string id = "";
            try
            {
                //kukunin yung id ng subcategory
                con.Open();
                string sql = "SELECT a.subCategory_id FROM tbl_subcategory a, tbl_category b WHERE a.category_id = b.category_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", subName);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["subCategory_id"].ToString();
                }
                con.Close();

                //kukunin yung bilang ng mga item per subcategory
                con.Open();
                string sql1 = "SELECT * FROM tbl_item WHERE subCategory_id = @id";
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@id", id);
                com1.ExecuteNonQuery();

                MySqlDataReader dr1 = com1.ExecuteReader();
                while (dr1.Read())
                {
                    count++;
                }
                con.Close();

                //<-----inserting ng new subcategory----->
                con.Open();
                string sql2 = "INSERT INTO tbl_item(`item_Name`,`item_Number`, `subCategory_id`) VALUES(@iN, @iNum, @id);";//inserting item-name
                MySqlCommand com2 = new MySqlCommand(sql2, con);
                com2.Parameters.AddWithValue("@iN", item);
                com2.Parameters.AddWithValue("@iNum", ++count);
                com2.Parameters.AddWithValue("@id", id);
                com2.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Created Successful", "Save!");
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message + "b" + count + "a" + id, "InsertItemName");
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertBrand(string cat, string code, string subName, string item, string brand)
        {
            int count = -1;
            string id = "";
            try
            {
                //kukunin yung id ng item
                con.Open();
                string sql = "SELECT c.item_id FROM tbl_subcategory a, tbl_category b, tbl_item c WHERE a.category_id = b.category_id AND a.subCategory_id = c.subCategory_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN AND c.item_Name = @iN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", subName);
                com.Parameters.AddWithValue("@iN", item);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["item_id"].ToString();
                }
                con.Close();

                //kukunin yung bilang ng mga brand per item
                con.Open();
                string sql1 = "SELECT * FROM tbl_brand WHERE item_id = @id";
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@id", id);
                com1.ExecuteNonQuery();

                MySqlDataReader dr1 = com1.ExecuteReader();
                while (dr1.Read())
                {
                    count++;
                }
                con.Close();

                //<-----inserting ng new BRAND----->
                con.Open();
                string sql2 = "INSERT INTO tbl_brand(`brand_Name`,`brand_Number`, `item_id`) VALUES(@bN, @bNum, @id);";//inserting brand name
                MySqlCommand com2 = new MySqlCommand(sql2, con);
                com2.Parameters.AddWithValue("@bN", brand);
                com2.Parameters.AddWithValue("@bNum", ++count);
                com2.Parameters.AddWithValue("@id", id);
                com2.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Created Successful", "Save!");
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message + "b" + count + "a" + id, "InsertBrand");
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertModel(string cat, string code, string subName, string item, string brand, string model)
        {
            int count = -1;
            string id = "";
            try
            {
                //kukunin yung id ng brand
                con.Open();
                string sql = "SELECT d.brand_id FROM tbl_subcategory a, tbl_category b, tbl_item c, tbl_brand d WHERE a.category_id = b.category_id AND a.subCategory_id = c.subCategory_id AND c.item_id = d.item_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN AND c.item_Name = @iN AND d.brand_Name = @bN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", subName);
                com.Parameters.AddWithValue("@iN", item);
                com.Parameters.AddWithValue("@bN", brand);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["brand_id"].ToString();
                }
                con.Close();

                //kukunin yung bilang ng mga model per brand
                con.Open();
                string sql1 = "SELECT * FROM tbl_model WHERE brand_id = @id;";
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@id", id);
                com1.ExecuteNonQuery();

                MySqlDataReader dr1 = com1.ExecuteReader();
                while (dr1.Read())
                {
                    count++;
                }
                con.Close();

                //<-----inserting ng new model----->
                con.Open();
                string sql2 = "INSERT INTO tbl_model(`model_Name`,`model_Number`, `brand_id`) VALUES(@mN, @mNum, @id);";//inserting brand name
                MySqlCommand com2 = new MySqlCommand(sql2, con);
                com2.Parameters.AddWithValue("@mN", model);
                com2.Parameters.AddWithValue("@mNum", ++count);
                com2.Parameters.AddWithValue("@id", id);
                com2.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Created Successful", "Save!");
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message + "b" + count + "a" + id, "InsertModel");
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertDescription(string cat, string code, string subName, string item, string brand, string model, string description)
        {
            int count = -1;
            string id = "";
            try
            {
                //kukunin yung id ng model
                con.Open();
                string sql = "SELECT e.model_id FROM tbl_subcategory a, tbl_category b, tbl_item c, tbl_brand d, tbl_model e WHERE a.category_id = b.category_id AND a.subCategory_id = c.subCategory_id AND c.item_id = d.item_id AND d.brand_id = e.brand_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN AND c.item_Name = @iN AND d.brand_Name = @bN AND e.model_Name = @mN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", subName);
                com.Parameters.AddWithValue("@iN", item);
                com.Parameters.AddWithValue("@bN", brand);
                com.Parameters.AddWithValue("@mN", model);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["model_id"].ToString();
                }
                con.Close();

                //kukunin yung bilang ng mga model per brand
                con.Open();
                string sql1 = "SELECT * FROM tbl_description WHERE model_id = @id;";
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@id", id);
                com1.ExecuteNonQuery();

                MySqlDataReader dr1 = com1.ExecuteReader();
                while (dr1.Read())
                {
                    count++;
                }
                con.Close();

                //<-----inserting ng new description----->
                con.Open();
                string sql2 = "INSERT INTO tbl_description(`description_Name`,`description_Number`, `model_id`) VALUES(@dN, @dNum, @id);";//inserting brand name
                MySqlCommand com2 = new MySqlCommand(sql2, con);
                com2.Parameters.AddWithValue("@dN", description);
                com2.Parameters.AddWithValue("@dNum", ++count);
                com2.Parameters.AddWithValue("@id", id);
                com2.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Created Successful", "Save!");
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message + "b" + count + "a" + id, "InsertDescription");
            }
            finally
            {
                con.Close();
            }
        }
        
        public void UpdateItemCode(string id, string cat, string subName, string item, string brand, string model, string description)
        {
            try
            {
                con.Open();
                string sql1 = @"UPDATE tbl_itemcode SET
                            `itemCode_Category` = @cat,
                            `itemCode_SubCategory` = @subCat,
                            `itemCode_ItemName` = @item,
                            `itemCode_Brand` = @brand,
                            `itemCode_Model` = @model,
                            `itemCode_Description` = @desc,
                            `updated_at` = @date2
                            WHERE `id` = @id;";//update item code
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@id", id);
                com1.Parameters.AddWithValue("@cat", cat);
                com1.Parameters.AddWithValue("@subCat", subName);
                com1.Parameters.AddWithValue("@item", item);
                com1.Parameters.AddWithValue("@brand", brand);
                com1.Parameters.AddWithValue("@model", model);
                com1.Parameters.AddWithValue("@desc", description);
                com1.Parameters.AddWithValue("@date2", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                com1.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Created Successful", "Save!");
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "UpdateItemCode");
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteItemCode(string id)
        {
            try
            {
                con.Open();
                string sql1 = @"DELETE FROM tbl_itemcode
                            WHERE `id` = @id;";//Delete item code
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@id", id);
                com1.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Created Successful", "Save!");
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "DeleteItemCode");
            }
            finally
            {
                con.Close();
            }
        }

        public string[] ShowSC(string cat)
        {
            string[] cont = new string[100];
            for (int x = 0; x < 100; x++)
                cont[x] = "";

            int num = 0;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_subcategory a, tbl_category b WHERE a.category_id = b.category_id AND b.category_Name = @cN;";
                
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    cont[num++] = dr1["subCategory_Name"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "select SubCategory");
            }
            finally
            {
                con.Close();
            }
            return cont;

        }

        //===============Purchase Request=============
        public int getPRNo()
        {
            int usersResult = 0;
            try
            {
                con.Open();
                string sql1 = @"SELECT * FROM tbl_pr_no ORDER BY pr_no DESC LIMIT 1;";//select pr no

                MySqlCommand com = new MySqlCommand(sql1, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    usersResult = Convert.ToInt32(dr["pr_no"].ToString());

                    usersResult = Convert.ToInt32(usersResult) + 1;
                }
                else
                {
                    usersResult = 1001;
                }
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "getPRNo");
            }
            finally
            {
                con.Close();
            }
            return usersResult;

        }

        public void PRno_insert(string prNO, string name)
        {
            try
            {
                con.Open();
                string sql1 = @"INSERT INTO `db_spml_inventory`.`tbl_pr_no`
                            (`pr_no`,
                            `name`)
                            VALUES
                            (@prNo,
                            @name);";//inserting pr NO
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@prNo", prNO);
                com1.Parameters.AddWithValue("@name", name);
                com1.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "PRno_insert");
            }
            finally
            {
                con.Close();
            }
        } 

        public void PR_insert(string prNO, string requestor, string contactNumber, string dept, string projectName, string businessType, string date1, string date2, string cost, string purpose, string priority, string entry, string[,] info)
        {
            for(int x = 0; x < Convert.ToInt32(entry); x++)
            try
            {
                con.Open();
                string sql1 = @"INSERT INTO tbl_purchase_request
                        (
                        `pr_no`,
                        `pr_requestor_name`,
                        `contact_number`,
                        `department`,
                        `project_name`,
                        `business_type`,
                        `requisition_date`,
                        `required_date`,
                        `cost_center`,
                        `purpose`,
                        `priority`,
                        `type_of_supply`,
                        `item`,
                        `description`,
                        `category`,
                        `quantity`,
                        `unit`,
                        `updated_at`,
                        `created_at`)
                        VALUES
                        (
                        @pr_no,
                        @pr_requestor_name,
                        @contact_number,
                        @department,
                        @project_name,
                        @business_type,
                        @requisition_date,
                        @required_date,
                        @cost_center,
                        @purpose,
                        @priority,
                        @type_of_supply,
                        @item,
                        @description,
                        @category,
                        @quantity,
                        @unit,
                        @updated_at,
                        @created_at);
                        ";//inserting pr
                MySqlCommand com1 = new MySqlCommand(sql1, con);

                com1.Parameters.AddWithValue("@pr_no", prNO);
                com1.Parameters.AddWithValue("@pr_requestor_name", requestor);
                com1.Parameters.AddWithValue("@contact_number", contactNumber);
                com1.Parameters.AddWithValue("@department", dept);
                com1.Parameters.AddWithValue("@project_name", projectName);
                com1.Parameters.AddWithValue("@business_type", businessType);
                com1.Parameters.AddWithValue("@requisition_date", date1);
                com1.Parameters.AddWithValue("@required_date", date2);
                com1.Parameters.AddWithValue("@cost_center", cost);
                com1.Parameters.AddWithValue("@purpose", purpose);
                com1.Parameters.AddWithValue("@priority", priority);
                com1.Parameters.AddWithValue("@type_of_supply", info[x, 0]);
                com1.Parameters.AddWithValue("@item", info[x, 1]);
                com1.Parameters.AddWithValue("@description", info[x, 2]);
                com1.Parameters.AddWithValue("@category", info[x, 3]);
                com1.Parameters.AddWithValue("@quantity", info[x, 4]);
                com1.Parameters.AddWithValue("@unit", info[x, 5]);
                com1.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                com1.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                com1.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "PR_insert");
            }
            finally
            {
                con.Close();
            }
        }

        public DataGridView dgv_showPR()
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = @"SELECT 
                            `id`,
                            `pr_no`,
                            `pr_requestor_name`,
                            `contact_number`,
                            `department`,
                            `project_name`,
                            `business_type`,
                            `requisition_date`,
                            `required_date`,
                            `cost_center`,
                            `purpose`,
                            `priority`,
                            `type_of_supply`,
                            `item`,
                            `description`,
                            `category`,
                            `quantity`,
                            `unit` FROM tbl_purchase_request;";

                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_showPR");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        //===============accounts===============
        public string[] ShowAccountInfor(string id)
        {
            string[] cont = new string[200];
           
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_users WHERE user_id = @id;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", id);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    cont[0] = dr1["firstName"].ToString();
                    cont[1] = dr1["middleName"].ToString();
                    cont[2] = dr1["lastName"].ToString();
                    cont[3] = dr1["userType"].ToString();
                    cont[4] = dr1["position"].ToString();
                    cont[5] = dr1["department"].ToString();
                    cont[6] = dr1["username"].ToString();
                    cont[7] = dr1["password"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "ShowAccountInfo");
            }
            finally
            {
                con.Close();
            }
            return cont;
        }

        public void Account_update(string id, string fname, string mname, string lname, string pos, string dept, string user, string pass )
        {
            try
            {
                con.Open();
                string sql1 = @"UPDATE tbl_users SET
                            `firstName` = @fn,
                            `middleName` = @mn,
                            `lastName` = @ln,
                            `position` = @p,
                            `department` = @d,
                            `username` = @usr,
                            `password` = @pass,
                            `updated_at` = @date2
                            WHERE `user_id` = @id;";//update item code
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@id", id);
                com1.Parameters.AddWithValue("@fn", fname);
                com1.Parameters.AddWithValue("@mn", mname);
                com1.Parameters.AddWithValue("@ln", lname);
                com1.Parameters.AddWithValue("@p", pos);
                com1.Parameters.AddWithValue("@d", dept);
                com1.Parameters.AddWithValue("@usr", user);
                com1.Parameters.AddWithValue("@pass", pass);
                com1.Parameters.AddWithValue("@date2", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                com1.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Created Successful", "Save!");
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "Account_update");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
 