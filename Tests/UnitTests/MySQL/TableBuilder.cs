using Repositories.DB.Adaptors.MySQL.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;
using Tests.Core.Dumps;

namespace Tests.UnitTests.MySQL
{

    class TableBuilder : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            MySQLTableBuilder builder = new MySQLTableBuilder(new FakeDBConnection());

            // Yeni tablo oluşturma
            string sql = builder.CreateAsQuery("my_table");
            AssertEqual(sql, @"CREATE TABLE `my_table` (
              `id` INT NOT NULL AUTO_INCREMENT,
              `created_at` DATETIME NOT NULL,
              `updated_at` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
              `deleted_at` DATETIME NULL,
              `create_auth_id` INT NULL,
              `update_auth_id` INT NULL,
              `delete_auth_id` INT NULL,
              PRIMARY KEY (`id`)
            )
            ENGINE = InnoDB
            DEFAULT CHARACTER SET = utf8;");

            // Alan göre kayıt bulma
            sql = builder.FindAsQuery("my_table", "my_key");
            AssertEqual(sql, @"SELECT * FROM `my_table` WHERE `my_key` = @my_key");

            // Tablo silme
            sql = builder.DropAsQuery("my_table");
            AssertEqual(sql, @"DROP TABLE `my_table`");

            // Tablonun adını değiştirme
            sql = builder.RenameAsQuery("my_table", "new_table_name");
            AssertEqual(sql, @"RENAME TABLE `my_table` TO `new_table_name`;");

            // Yeni kayıt ekleme
            sql = builder.InsertAsQuery("my_table", new Dictionary<string, dynamic>()
            {
                {"name", "foo"},
                {"surname", "bar"},
                {"age", 12}
            });
            AssertEqual(sql, @"INSERT INTO my_table (`name`,`surname`,`age`,`CREATED_AT`) VALUES (@name,@surname,@age,'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');");

            // Kayıt güncelleme
            sql = builder.UpdateAsQuery("my_table", 1, new Dictionary<string, dynamic>()
            {
                {"name", "foo"},
                {"surname", "bar"},
                {"age", 12}
            });
            AssertEqual(sql, @"UPDATE my_table SET `name` = @name,`surname` = @surname,`age` = @age WHERE `id` = 1");

        }

    }

}
