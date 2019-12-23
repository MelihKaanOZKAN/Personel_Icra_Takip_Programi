using Devart.Data.PostgreSql;
using Npgsql;
using Personel_Icra_Takip_Programı.Classlar;

namespace Personel_Icra_Takip_Programı.Report
{


    partial class DB_PITPDataSet
    {
        partial class tb_personelDataTable
        {
        }
    }
}

namespace Personel_Icra_Takip_Programı.Report.DB_PITPDataSetTableAdapters
{
    partial class tb_personelTableAdapter
    {
        public void setSelectCommand(PgSqlCommand command, Report.DB_PITPDataSetTableAdapters.tb_personelTableAdapter tableAdapter)
        {
            tableAdapter.CommandCollection[0] = command;
            tableAdapter.Connection = dbConnection.getPgsqlConnection();
        }
    }

    public partial class DataTable1TableAdapter {
        public void setSelectCommand (PgSqlCommand command, Report.DB_PITPDataSetTableAdapters.DataTable1TableAdapter tableAdapter )
        {
            tableAdapter.CommandCollection[0] = command;
            tableAdapter.Connection = dbConnection.getPgsqlConnection();
        }
    }
}
