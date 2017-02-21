using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.SlawekKowal.Training4;
using SeeSharpBasics.Training4.Db;

namespace Toci.SeeSharpBasics.Test.SlawekKowal.Training4
{
    
        [TestClass]
        public class TestSql
        {
            [TestMethod]
            public void TestData()
            {
                PostgresqlDbClient dataBase = new SlawekKPostgresglDbClient();
                dataBase.Insert("insert into mytable (name, surname,telephone) values ('slawek','kowal','123123123')");
                var cc = dataBase.Select("select * from mytable");
                dataBase.Delete("delete from mytable where id = 2");
                dataBase.Update("update mytable set name = 'lukasz' where id > 8");
            }

        }
    
}