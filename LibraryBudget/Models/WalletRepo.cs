using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace LibraryBudget.Models
{
    public class WalletRepo
    {
        public List<Wallet> GetWallet()
        {
            using (IDbConnection connection = new SqlConnection(Helper.Constr("MijnBudget"))) 
            {
                return connection.Query<Wallet>("SELECT * From Wallet").ToList();
            }
        }

        public List<Wallet> GetWalletInOut(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Constr("MijnBudget")))
            {
                return connection.Query<Wallet>($"SELECT * From Wallet where MinPlus={id}").ToList();
            }
        }

        public void AddWallet(Wallet wallet)
        {
            string sql = "Insert INTO Wallet(Description, MinPlus, Amount, Type)" +
            "VALUES(@Description, @MinPlus, @Amount, @Type)";
            using (IDbConnection connection = new SqlConnection(Helper.Constr("MijnBudget")))
            {
                connection.Query(sql, wallet).ToList();
            }
        }
        public void UpdateWallet(Wallet wallet)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Constr("MijnBudget")))
            {
                connection.Execute("UPDATE Wallet SET Description=@Description, MinPlus=@MinPlus, " +
                    "Amount=@Amount, Type=@Type WHERE Id=@Id", 
                new { Description = wallet.Description, MinPlus = wallet.MinPlus, Amount = wallet.Amount, Type = wallet.Type, Id = wallet.Id });
            }
        }

        public List<TypeOfAmount> GetAmountTypes()
        {
            using (IDbConnection connection = new SqlConnection(Helper.Constr("MijnBudget")))
            {
                return connection.Query<TypeOfAmount>("SELECT * From TypeOfAmount").ToList();
            }
        }

        public List<Type> GetTypes()
        {
            using (IDbConnection connection = new SqlConnection(Helper.Constr("MijnBudget")))
            {
                return connection.Query<Type>("SELECT * From Type").ToList();
            }
        }
        public void DeleteWallet(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Constr("MijnBudget")))
            {
                connection.Execute("DELETE FROM Wallet where Id=@id", new { Id = id });
            }
        }
        public List<Wallet> GetDescriptionOfAmountType(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Constr("MijnBudget")))
            {
                var list = connection.Query<Wallet>("SELECT * from Wallet where MinPlus=@Id",
                    new { Id = id }).ToList();
                return list;
            }
        }

        //public int ShowBalance()
        //{
        //    foreach (var item in collection)
        //    {

        //    }
        //}

        public string GetWalletBalance()
        {
            using (IDbConnection connection = new SqlConnection(Helper.Constr("MijnBudget")))
            {
                var value= connection.Query<Wallet>("select sum(Amount) as SumIncome from Wallet  where MinPlus like 1")/*.ToList()*/;
                return Convert.ToString(value);
            }
        }
    }
}
