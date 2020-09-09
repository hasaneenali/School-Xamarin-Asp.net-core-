using Newtonsoft.Json;
using Plugin.Connectivity;
using School.Common.Model;
using School.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace School.Mobile.Services
{
    public static class ApiService
    {

        public static async Task<bool> CheckConnection(string url)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                return false;
            }

            return await CrossConnectivity.Current.IsRemoteReachable(url);
        }
        #region Material
        public static async Task<List<Material>> GetMaterials()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://school-web.conveyor.cloud/api/Materials");
            var Materials = JsonConvert.DeserializeObject<List<Material>>(json);
            return Materials;
        }

       

        public static async Task AddMaterials(Material material)
        {
           
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(material);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await httpClient.PostAsync("https://school-web.conveyor.cloud/api/Materials", content);
           
        }

          public static async Task InsertAllMaterial(List<Material> material)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(material);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await httpClient.PostAsync("https://school-web.conveyor.cloud/api/Materials/AddMaterial", content);
        }

        public static async Task EditMaterials(int id, Material material)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(material);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await httpClient.PutAsync("https://school-web.conveyor.cloud/api/Materials/" + id, content);
        }

        public static async Task DeleteMaterials(int id)
        {
            var httpClient = new HttpClient();
            await httpClient.DeleteAsync("https://school-web.conveyor.cloud/api/Materials/" + id);
        }
        #endregion

        #region Teacher
        public static async Task<List<Teacher>> GetTeachers()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://school-web.conveyor.cloud/api/Teachers");
            var data = JsonConvert.DeserializeObject<List<Teacher>>(json);
            return data;
        }

       

        public static async Task AddTeachers(Teacher teacher)
        {

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(teacher);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await httpClient.PostAsync("https://school-web.conveyor.cloud/api/Teachers", content);

        }

        public static async Task EditTeachers(int id,Teacher teacher)
        {

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(teacher);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await httpClient.PutAsync("https://school-web.conveyor.cloud/api/Teachers/"+ id, content);

        }

        public static async Task DeleteTeachers(int id)
        {
            var httpClient = new HttpClient();
            await httpClient.DeleteAsync("https://school-web.conveyor.cloud/api/Teachers/" + id);
        }
        #endregion


        #region Student

        public static async Task AddStudent(Student student)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(student);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await httpClient.PostAsync("https://school-web.conveyor.cloud/api/Students", content);
        }

        public static async Task<List<Student>> GetStudents()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://school-web.conveyor.cloud/api/Students");
            var student = JsonConvert.DeserializeObject<List<Student>>(json);
            return student;
          
        }
        #endregion

        #region results

        public static async Task<List<Result>> GetResults()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://school-web.conveyor.cloud/api/Results");
            var Results = JsonConvert.DeserializeObject<List<Result>>(json);
            return Results;
        }
        #endregion


        public static async void AddResult(Result result)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(result);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await httpClient.PostAsync("https://school-web.conveyor.cloud/api/Results", content);
        }
    }
}
