using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<List<ProjectSubMemberAsgmt>> GetAllMemberAssign() //get all RA Type master data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/ProjectSubMemberAsgmt/");

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectSubMemberAsgmt>>();
            return obj;
        }
    }
}
