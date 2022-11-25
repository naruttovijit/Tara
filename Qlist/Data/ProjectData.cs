using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Qlist.ModelM2s;

namespace Qlist.Data
{
    public class ProjectData
    {
        public async Task<List<ProjectHd>> GetProjectHD() //get all project master data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/ProjectHD/");

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectHd>>();
            return obj;
        }

        public async Task<ProjectHd> GetProjectHDbyID(int id) //get project master data by id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/ProjectHD/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<ProjectHd>();
            return obj;
        }

        public async Task<List<ProjectSubProjectTl>> GetProjectSubProjectTL() //get project sub by project master id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/ProjectSubProjectTl/");

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectSubProjectTl>>();
            return obj;
        }

        public async Task<ProjectSubProjectTl> GetProjectSubProjectTLbyID(int id) //get project sub by project master id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/ProjectSubProjectTl/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<ProjectSubProjectTl>();
            return obj;
        }

        public async Task<List<RatypeMaster>> GetRAType() //get all RA Type master data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/RatypeMaster/");

            var obj = await response.Content.ReadFromJsonAsync<List<RatypeMaster>>();
            return obj;
        }

        public async Task<List<ProjectDocument>> GetAllProjectDocument() //get all project document data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/ProjectDocument");

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectDocument>>();
            return obj;
        }

        public async Task<List<ProjectRatypeTl>> GetAllProjectRAType() //get all project RA type data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/ProjectRatypeTl");

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectRatypeTl>>();
            return obj;
        }

        public async Task<List<ProjectSubMemberAsgmt>> GetAllMemberAssign() //get all member assignment data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/ProjectSubMemberAsgmt/");

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectSubMemberAsgmt>>();
            return obj;
        }

        public async Task<ProjectHd> SaveProjectHD(ProjectHd projecthd) //save all data
        {
            HttpClient hc = new HttpClient();
            var json = JsonConvert.SerializeObject(projecthd);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await hc.PostAsync("https://taraapi.ddns.net/api/ProjectHD/", data);

            var result = await response.Content.ReadFromJsonAsync<ProjectHd>();
            return result;
        }

        public async Task SaveMemberAssign(string memberassign) //save member assign data
        {
            HttpClient hc = new HttpClient();
            //var json = JsonConvert.SerializeObject(memberassign);
            var data = new StringContent(memberassign, Encoding.UTF8, "application/json");
            var response = await hc.PostAsync("https://taraapi.ddns.net/api/ProjectSubMemberAsgmt/", data);

            var result = await response.Content.ReadFromJsonAsync<ProjectSubMemberAsgmt>();
            //return result;
        }
    }
}
