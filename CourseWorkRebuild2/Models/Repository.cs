using CourseWorkRebuild2;
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
        private String tableName = "";

        public Repository(String pathToElevatorTable)
        {
            this.pathToElevatorTable = pathToElevatorTable;
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
            ChooseTableForm form = new ChooseTableForm();
            while (reader.Read())
            {
                form.GetComboBox().Items.Add(reader.GetString(0));
            }
            if (form.GetComboBox().Items.Count > 1)
            {
                form.ShowDialog();
                tableName = form.GetApplyedTable();
                form.Close();
            }
            else tableName = form.GetComboBox().Items[0].ToString() ;
            return tableName;
        }

        public DataGridView ShowTable(DataTable dataTable, DataGridView elevatorTable)
        {
            GetTableNames();
            String SQLQuery = "SELECT * FROM [" + tableName + "]";
            dataTable.Rows.Clear();
            dataTable.Columns.Clear();
            SQLiteCommand command = new SQLiteCommand(sqlConnection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(SQLQuery, sqlConnection);
            adapter.Fill(dataTable);

            for (int i = 1; i < dataTable.Columns.Count; i++)
            {
                String replaceCommosToDots = "UPDATE [" + tableName + "] SET[" + i + "] = REPLACE([" + i + "],',','.')";
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
            String updateQuery = "UPDATE [" + tableName + "] SET \"" + currentColumn + "\" = \"" + newValue + "\" WHERE Эпоха = \'" + currentRow + "\'";
            SQLiteCommand command = new SQLiteCommand(sqlConnection);
            command.CommandText = updateQuery;
            command.ExecuteNonQuery();
            return elevatorTable;
        }

        public void AddNewValuesInRow(int column, int row, Double value)
        {
            String SQLQuery = "UPDATE [" + tableName + "] SET \"" + column + "\" = \"" + value + "\" WHERE Эпоха = \'" + row + "\'";
            SQLiteCommand command = new SQLiteCommand(sqlConnection);
            command.CommandText = SQLQuery;
            command.ExecuteNonQuery();
        }
        public void AddNewRow(int index)
        {
            String SQLQuery = "INSERT INTO [" + tableName + "] (Эпоха) VALUES (\"" + index + "\")";
            SQLiteCommand command = new SQLiteCommand(sqlConnection);
            command.CommandText = SQLQuery;
            command.ExecuteNonQuery();
        }
        public void DeleteRow(String index)
        {
            String SQLQuery = "DELETE FROM [" + tableName + "] WHERE Эпоха = \'" + index + "\'";
            SQLiteCommand command = new SQLiteCommand(sqlConnection);
            command.CommandText = SQLQuery;
            command.ExecuteNonQuery();
        }

    }
}
