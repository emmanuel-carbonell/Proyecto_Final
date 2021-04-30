using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;




namespace Datos 

{

    public class conexionbd
    {
     
            string cadena = "Data Source= FAMILIA-CARBONE; Initial Catalog=SMARTECH; Integrated security=true";
            public SqlConnection conectarbd = new SqlConnection();


        
    }
}

