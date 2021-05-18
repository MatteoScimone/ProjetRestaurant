using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1Resteau1.Resteau
{
   public class PlatRepository
   {
        private SQLiteAsyncConnection connection;

        public string StatusMessage { get; set; }

        public PlatRepository(string dbPath)
        {
            connection = new SQLiteAsyncConnection(dbPath);
            connection.CreateTableAsync<Plat>();
        }
        public async Task AddNewPlatAsync(string nom)
        {
            int result = 0;

            try
            {
                result = await connection.InsertAsync(new Plat { Nom = nom });
                StatusMessage = $"{result} plat ajouté : {nom}";
            }
            catch (Exception ex)
            {

                StatusMessage = $"Impossible d'ajouter un plat : {nom}.\n Erreur : {ex.Message}";
            }
        }
        public async Task<List<Plat>> GetPlatsAsync()
        {
            try
            {
                return await connection.Table<Plat>().ToListAsync();
            }
            catch ( Exception ex)
            {
                StatusMessage = $"Impossible de récupérer la liste des plats.\n Erreur : {ex.Message}";

            }
            return new List<Plat>();

        }
  
   }
}
