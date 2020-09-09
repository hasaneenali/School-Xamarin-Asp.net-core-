using School.Mobile.Interfaces;
using School.Mobile.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace School.Mobile.Services
{
    public class DataService
    {
        private SQLiteAsyncConnection connection;


        public DataService()
        {
            OpenOrCreateDB();
        }

        private async void OpenOrCreateDB()
        {
            var databasePath = DependencyService.Get<IPathService>().GetDatabasePath(); //Obtiene la ruta, si no la tiene, la crea
            this.connection = new SQLiteAsyncConnection(databasePath);
            await connection.CreateTableAsync<Material>().ConfigureAwait(false);
            await connection.CreateTableAsync<TeachrData>().ConfigureAwait(false);
         

        }

        public async Task Insert<T>(T model)
        {
            await this.connection.InsertAsync(model);
        }

        public async Task InsertAll<T>(List<T> models)
        {
            await this.connection.InsertAllAsync(models);
        }

        public async Task Update<T>(T model)
        {
            await this.connection.UpdateAsync(model);
        }

        public async Task Update<T>(List<T> models)
        {
            await this.connection.UpdateAllAsync(models);
        }

        public async Task Delete<T>(T model)
        {
            await this.connection.DeleteAsync(model);
        }


        public async Task DeleteAllProducts()
        {
            await this.connection.QueryAsync<Material>("delete from [Material]");
        }


        public async Task<List<Material>> GetAllProducts()
        {
            var query = await this.connection.QueryAsync<Material>("select * from [Material]"); // Hace la query y la guarda en la variable query
            var array = query.ToArray();// 

            var list = array.Select(
                p => new Material
                {
                    Name = p.Name,
                   
                }).ToList(); // transforma el array a list
            return list;
        }

        public async Task<List<TeachrData>> AllGetTeachrData()
        {
            var query = await this.connection.QueryAsync<TeachrData>("select * from [TeachrData]"); // Hace la query y la guarda en la variable query
            var array = query.ToArray();// 

            var list = array.Select(
                p => new TeachrData
                {
                    Name = p.Name,
                    Age = p.Age,
                    Mobile = p.Mobile,
                    ImageUrl = p.ImageUrl,

                })
                .ToList(); // transforma el array a list
                 return list;

           
        }


    }

   


}
