using System;
using System.Data;
using System.Data.SQLite;
using System.Threading;
using System.Windows.Forms;

namespace CourseWorkRebuild
{
    internal class Repository
    {
        public String pathToElevatorTable = "";
        private SQLiteConnection sqlConnection;

        public Repository(String pathToElevatorTable)
        {
            this.pathToElevatorTable = pathToElevatorTable;
        }
        public void closeSQLConnection()
        {
            sqlConnection.Close();
        }

        public SQLiteConnection GetDbConnection()
        {
            this.sqlConnection = new SQLiteConnection("Data Source=" + pathToElevatorTable + ";Version=3;");
            this.sqlConnection.Open();
            return this.sqlConnection;

        }

        public String GetTableNames()
        {
            String SQLQuery = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;";
            SQLiteCommand command = new SQLiteCommand(SQLQuery, sqlConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            String tableName = "";

            //сделать выбор таблицы
            while (reader.Read())
            {
                tableName = reader.GetString(0);
            }

            return tableName;
        }

        public DataGridView ShowTable(DataTable dataTable, DataGridView elevatorTable)
        {
            String SQLQuery = "SELECT * FROM [" + GetTableNames() + "]";
            dataTable.Rows.Clear();
            dataTable.Columns.Clear();
            SQLiteCommand command = new SQLiteCommand(sqlConnection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(SQLQuery, sqlConnection);
            adapter.Fill(dataTable);

            for (int i = 1; i < dataTable.Columns.Count; i++)
            {
                String replaceCommosToDots = "UPDATE [" + GetTableNames() + "] SET[" + i + "] = REPLACE([" + i + "],',','.')";
                command.CommandText = replaceCommosToDots;
                command.ExecuteNonQuery();
                Thread.Sleep(10);
            }

            dataTable.Rows.Clear();
            dataTable.Columns.Clear();

            adapter = new SQLiteDataAdapter(SQLQuery, sqlConnection);
            adapter.Fill(dataTable);

            elevatorTable.Columns.Clear();
            elevatorTable.Rows.Clear();

            for (int column = 0; column < dataTable.Columns.Count; column++)
            {
                String ColName = dataTable.Columns[column].ColumnName;
                elevatorTable.Columns.Add(ColName, ColName);
                elevatorTable.Columns[column].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                elevatorTable.Rows.Add(dataTable.Rows[row].ItemArray);
            }
            return elevatorTable;

        }

        public DataGridView UpdateValue(DataGridView elevatorTable, int currentColumn, int currentRow, Double newValue)
        {
            String updateQuery = "UPDATE [" + GetTableNames() + "] SET \"" + currentColumn + "\" = \"" + newValue + "\" WHERE Эпоха = \'" + currentRow + "\'";
            SQLiteCommand command = new SQLiteCommand(sqlConnection);
            command.CommandText = updateQuery;
            command.ExecuteNonQuery();
            return elevatorTable;
        }

        public void AddNewValuesInRow(int column, int row, Double value)
        {
            String SQLQuery = "UPDATE [" + GetTableNames() + "] SET \"" + column + "\" = \"" + value + "\" WHERE Эпоха = \'" + row + "\'";
            SQLiteCommand command = new SQLiteCommand(sqlConnection);
            command.CommandText = SQLQuery;
            command.ExecuteNonQuery();
        }
        public void AddNewRow(int index)
        {
            String SQLQuery = "INSERT INTO [" + GetTableNames() + "] (Эпоха) VALUES (\"" + index + "\")";
            SQLiteCommand command = new SQLiteCommand(sqlConnection);
            command.CommandText = SQLQuery;
            command.ExecuteNonQuery();
        }
        public void DeleteRow(String index)
        {
            String SQLQuery = "DELETE FROM [" + GetTableNames() + "] WHERE Эпоха = \'" + index + "\'";
            SQLiteCommand command = new SQLiteCommand(sqlConnection);
            command.CommandText = SQLQuery;
            command.ExecuteNonQuery();
        }

    }
}
