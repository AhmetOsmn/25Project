using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.OOP_Database
{

    public class KitapDb
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =C:\Projects\25Project\24.OOP+Database\Kutuphane.accdb");

        public List<Kitap> Listele()
        {
            List<Kitap> kitapList = new List<Kitap>();
            connection.Open();
            OleDbCommand command = new OleDbCommand("select * from Kitaplar",connection);
            OleDbDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Kitap k = new Kitap();
                k.ID = Convert.ToInt32(dr[0].ToString());
                k.Ad = dr[1].ToString();
                k.Yazar = dr[2].ToString();

                kitapList.Add(k);
            }

            connection.Close();
            return kitapList;
        }

        public void KitapEkle(Kitap kitap)
        {
            connection.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Kitaplar (KitapAd,Yazar) values(@p1,@p2)",connection);
            cmd.Parameters.AddWithValue("@p1",kitap.Ad);
            cmd.Parameters.AddWithValue("@p2",kitap.Yazar);
            cmd.ExecuteNonQuery();
            connection.Close();
        }


    }
}
