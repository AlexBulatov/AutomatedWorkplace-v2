using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using NpgsqlTypes;

namespace ARMv2
{
    public static class PostgresConnector
    {
        //Соединяется с базой данных
        public static NpgsqlConnection connector = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;Username=postgres;Password=1");

        //Хранит результаты выборки
        public static NpgsqlDataAdapter store;
        public static string QueryString;
        
        //<summary>
        //Выборка одной карты с ID
        //</summary>
        public static Model.AmbulatorCard GetAmbulatorCard(int id){
            Model.AmbulatorCard selector = new Model.AmbulatorCard(id);
            connector.Open();
            QueryString = string.Format("SELECT * FROM clientbase WHERE id={0};", id);
            NpgsqlCommand Command = new NpgsqlCommand(QueryString, connector);
            NpgsqlDataReader Reader = Command.ExecuteReader();
            while(Reader.Read())
            {
                selector.Breeder = Reader["breeder"].ToString();
                selector.IsMale = selector.StringToGender(Reader["gender"].ToString());
                selector.KindOfAnimal = Reader["kindofanimal"].ToString();
                selector.Phone = Reader["phone"].ToString();
                selector.PetName = Reader["petname"].ToString();
                selector.DateOfBirth = (DateTime)Reader["dateofbirth"];
                selector.Breed = Reader["breed"].ToString();
                selector.Address = Reader["address"].ToString();
                selector.FirstVisitDate = (DateTime)Reader["dateoffirst"];
            }
            connector.Close();
            return selector;
            
        }
 
        //<summary>
        // Инициализация главного окна
        //</summary>
        public static void FirstInitialize(ref DataSet dataSet){
            connector.Open();
            
            QueryString = "Select id, breeder, address, phone, kindofanimal, breed, petname, dateofbirth, gender, dateoffirst From clientbase ORDER BY id DESC";
            store = new NpgsqlDataAdapter(QueryString, connector);
            var Map2 = store.TableMappings.Add("clientbase", "Амбулаторные карты");
            Map2.ColumnMappings.Add("id", "№");
            Map2.ColumnMappings.Add("breeder", "Владелец");
            Map2.ColumnMappings.Add("address", "Адрес");
            Map2.ColumnMappings.Add("phone", "Телефон");
            Map2.ColumnMappings.Add("kindofanimal", "Вид животного");
            Map2.ColumnMappings.Add("breed", "Порода");
            Map2.ColumnMappings.Add("petname", "Кличка");
            Map2.ColumnMappings.Add("dateofbirth", "Дата рождения");
            Map2.ColumnMappings.Add("gender", "Особь");
            Map2.ColumnMappings.Add("dateoffirst", "Первый приём");
            store.Fill(dataSet, "clientbase");

            QueryString = "Select * From recordincard ORDER BY idbase;";
            store = new NpgsqlDataAdapter(QueryString, connector);
            var Map3 = store.TableMappings.Add("recordincard", "Амбулаторные записи");
            Map3.ColumnMappings.Add("idbase", "Запись №");
            Map3.ColumnMappings.Add("tocard", "Карта №");
            Map3.ColumnMappings.Add("anamnesis", "Анамнез");
            Map3.ColumnMappings.Add("assignment", "Назначение");
            Map3.ColumnMappings.Add("epicrisis", "Диагноз");
            Map3.ColumnMappings.Add("payment", "Оплата");
            Map3.ColumnMappings.Add("dateofvisit", "Дата приема");
            Map3.ColumnMappings.Add("debt", "Задолженнсть");
            store.Fill(dataSet, "recordincard");

            store.Dispose();
            connector.Close();
        }

        public static DataTable GetRecordsForCard(int id){
            DataTable records = new DataTable();
            if (id != -1) QueryString = string.Format("Select * From recordincard WHERE tocard={0} ORDER BY idbase; ", id);
            else QueryString = string.Format("Select * From recordincard ORDER BY idbase; ");
            store = new NpgsqlDataAdapter(QueryString, connector);
            var Map = store.TableMappings.Add("recordincard", "Амбулаторные записи");
            Map.ColumnMappings.Add("idbase", "Запись №");
            Map.ColumnMappings.Add("tocard", "Карта №");
            Map.ColumnMappings.Add("anamnesis", "Анамнез");
            Map.ColumnMappings.Add("assignment", "Назначение");
            Map.ColumnMappings.Add("epicrisis", "Эпикриз");
            Map.ColumnMappings.Add("payment", "Оплата");
            Map.ColumnMappings.Add("dateofvisit", "Дата приема");
            Map.ColumnMappings.Add("debt", "Задолженность");
            store.Fill(records);
            return records;
        }

        public static Model.AmbulatorRecord GetRecord(int id){
            connector.Open();
            Model.AmbulatorRecord value = new Model.AmbulatorRecord(id);
            QueryString = string.Format("SELECT * FROM recordincard WHERE idbase={0}", id);
            NpgsqlCommand Command = new NpgsqlCommand(QueryString, connector);
            NpgsqlDataReader myDataReader = Command.ExecuteReader();
            while (myDataReader.Read())
            {
                value.DateVisit = (DateTime)(myDataReader["dateofvisit"]);
                value.anamnesis = myDataReader["anamnesis"].ToString().Trim();
                value.assignments = myDataReader["assignment"].ToString().Trim();
                value.epicrisis = myDataReader["epicrisis"].ToString().Trim();
                value.Payment = (int) myDataReader["payment"];
                value.ToCard = (int)myDataReader["tocard"];
                if (myDataReader["debt"].ToString()=="") value.Debt = 0;
                else value.Debt = (int)myDataReader["debt"];
            }
            myDataReader.Close();
            connector.Close();
            return value;
        }

        public static int InsertCard(Model.AmbulatorCard value){
            connector.Open();
            QueryString = "INSERT INTO clientbase (breeder, address, phone, kindofanimal, breed, petname, dateofbirth, gender, dateoffirst) " +
                         "VALUES(@Breeder, @Address, @Phone, @kindofanimal, @Breed, @Name, @DateOfBirth, @IsMale, @First);";
            NpgsqlCommand Command = new NpgsqlCommand(QueryString, connector);

            Command.Parameters.Add("@Breeder", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.Breeder;
            Command.Parameters.Add("@Address", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.Address;
            Command.Parameters.Add("@Phone", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.Phone;
            Command.Parameters.Add("@kindofanimal", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.KindOfAnimal;
            Command.Parameters.Add("@Breed", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.Breed;
            Command.Parameters.Add("@Name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.PetName;
            Command.Parameters.Add("@DateOfBirth", NpgsqlTypes.NpgsqlDbType.Date).Value = value.DateOfBirth;
            Command.Parameters.Add("@IsMale", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.IsMale ? "Мужская" : "Женская";
            Command.Parameters.Add("@First", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DateTime.Now;

            Command.ExecuteNonQuery();
            connector.Close();
            return 1;
        }

        public static int InsertRecord(int card, Model.AmbulatorRecord value){
            connector.Open();
            QueryString="INSERT INTO recordincard (tocard, dateofvisit, anamnesis, assignment, epicrisis, payment, debt) " +
                         "VALUES(@ToCard, @DateOfVisit, @Anamnesis, @Clinic, @Epicrisis, @Pay, @Debt);";
            NpgsqlCommand Command = new NpgsqlCommand(QueryString, connector);

            Command.Parameters.Add("@ToCard", NpgsqlTypes.NpgsqlDbType.Integer).Value = card;
            Command.Parameters.Add("@Pay", NpgsqlTypes.NpgsqlDbType.Integer).Value = value.Payment;
            Command.Parameters.Add("@DateOfVisit", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = value.DateVisit;
            Command.Parameters.Add("@Anamnesis", NpgsqlTypes.NpgsqlDbType.Text).Value = value.anamnesis;
            Command.Parameters.Add("@Clinic", NpgsqlTypes.NpgsqlDbType.Text).Value = value.assignments;
            Command.Parameters.Add("@Epicrisis", NpgsqlTypes.NpgsqlDbType.Text).Value = value.epicrisis;
            Command.Parameters.Add("@Debt", NpgsqlTypes.NpgsqlDbType.Integer).Value = value.Debt;

            Command.ExecuteNonQuery();
            connector.Close();
            return 1;
        }

        public static int UpdateCard(Model.AmbulatorCard value, int card) {
            Model.AmbulatorCard oldValue = GetAmbulatorCard(card);
            if (value == oldValue) return 2;
            connector.Open();
            QueryString = string.Format("UPDATE clientbase SET breeder = @Breeder, address = @Address, phone = @Phone, kindofanimal = @kindofanimal, breed = @Breed, petname = @Name, dateofbirth = @DateOfBirth, gender = @IsMale WHERE id = { 0 }; ", card);

            NpgsqlCommand Command = new NpgsqlCommand(QueryString,connector);
            Command.Parameters.Add("@Breeder", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.Breeder;
            Command.Parameters.Add("@Address", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.Address;
            Command.Parameters.Add("@Phone", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.Phone;
            Command.Parameters.Add("@kindofanimal", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.KindOfAnimal;
            Command.Parameters.Add("@Breed", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.Breeder;
            Command.Parameters.Add("@Name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.PetName;
            Command.Parameters.Add("@DateOfBirth", NpgsqlTypes.NpgsqlDbType.Date).Value = value.DateOfBirth;
            Command.Parameters.Add("@IsMale", NpgsqlTypes.NpgsqlDbType.Varchar).Value = value.IsMale ? "Мужская" : "Женская";
            Command.Parameters.Add("@First", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DateTime.Now;

            Command.ExecuteNonQuery();
            connector.Close();
            return 1;
        }

        public static int UpdateRecord(Model.AmbulatorRecord value, int record){
            Model.AmbulatorRecord oldValue = GetRecord(record);
            if (oldValue == value) return 2;
            connector.Open();
            QueryString = string.Format("UPDATE recordincard SET dateofvisit=@DateOfVisit, payment=@Pay, anamnesis=@Anamnesis, assignment=@Clinic, epicrisis=@Epicrisis, debt=@Debt WHERE idbase={0}", record);
            NpgsqlCommand Command = new NpgsqlCommand(QueryString, connector);

            Command.Parameters.Add("@Pay", NpgsqlTypes.NpgsqlDbType.Integer).Value = value.Payment;
            Command.Parameters.Add("@DateOfVisit", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = value.DateVisit;
            Command.Parameters.Add("@Anamnesis", NpgsqlTypes.NpgsqlDbType.Text).Value = value.anamnesis;
            Command.Parameters.Add("@Clinic", NpgsqlTypes.NpgsqlDbType.Text).Value = value.assignments;
            Command.Parameters.Add("@Epicrisis", NpgsqlTypes.NpgsqlDbType.Text).Value = value.epicrisis;
            Command.Parameters.Add("@Debt", NpgsqlDbType.Integer).Value = value.Debt;

            Command.ExecuteNonQuery();
            connector.Close();
            return 1;
        }

        public static int DeleteRecord(int record){
            connector.Open();
            QueryString = string.Format("DELETE FROM recordincard WHERE idbase={0};", record);
            NpgsqlCommand Command = new NpgsqlCommand(QueryString, connector);
            Command.ExecuteNonQuery();
            connector.Close();
            return 1;
        }

        public static int DeleteCard(int card){
            connector.Open();
            QueryString = string.Format("DELETE FROM recordincard WHERE tocard={0};", card);
            NpgsqlCommand Command = new NpgsqlCommand(QueryString, connector);
            Command.ExecuteNonQuery();
            
            QueryString = string.Format("DELETE FROM clientbase WHERE id ={0};", card);
            Command = new NpgsqlCommand(QueryString, connector);
            Command.ExecuteNonQuery();

            connector.Close();
            return 1;
        }

        public static DataTable SelectCard(string query){
            DataTable dataTable = new DataTable();
            store = new NpgsqlDataAdapter(query, connector);
            var Map = store.TableMappings.Add("clientbase", "Амбулаторные карты");
            Map.ColumnMappings.Add("id", "№");
            Map.ColumnMappings.Add("breeder", "Владелец");
            Map.ColumnMappings.Add("address", "Адрес");
            Map.ColumnMappings.Add("phone", "Телефон");
            Map.ColumnMappings.Add("kindofanimal", "Вид животного");
            Map.ColumnMappings.Add("breed", "Порода");
            Map.ColumnMappings.Add("petname", "Кличка");
            Map.ColumnMappings.Add("dateofbirth", "Дата рождения");
            Map.ColumnMappings.Add("gender", "Особь");
            Map.ColumnMappings.Add("dateoffirst", "Первое посещение");
            store.Fill(dataTable);
            return dataTable;
        }
    }
}
