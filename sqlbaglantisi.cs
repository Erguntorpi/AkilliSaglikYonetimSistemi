﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    class Sqlbaglantisi
    {
      public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=HastaneProje;Integrated Security=True;TrustServerCertificate=True;");
            baglan.Open();
            return baglan;
        }
    }
}
