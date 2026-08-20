using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using.System.Data;

namespace CarWashManagementSystem
{
    internal class c1
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\apurb\\Desktop\\CAR WASH AND MODIFICATION System\\CarWashManagementSystem\\DBCarWash.mdf\";Integrated Security=True");

        SqlCommand cmd = new SqlCommand("SELECT * FROM Customer.", conn);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
    }
}
