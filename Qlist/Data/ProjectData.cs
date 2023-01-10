using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Qlist.ModelM2s;
using Qlist.ModelM4s;

namespace Qlist.Data
{
    public class ProjectData
    {
        #region Module 2
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

        public async Task<ProjectRatypeTl> GetProjectRATypeBySubProjectID(int id) //get project RA type data by sub project id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/ProjectRatypeTl/GetByProjectSubProjectTLID/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<ProjectRatypeTl>();
            return obj;
        }

        public async Task<List<MasterCapabilityCat>> GetAllCapability() //get all project RA type data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/MasterCapabilityCat");

            var obj = await response.Content.ReadFromJsonAsync<List<MasterCapabilityCat>>();
            return obj;
        }

        public async Task<ProjectSubMemberAsgmt> GetMemberAssign(int id) //get member assignment data by id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/ProjectSubMemberAsgmt/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<ProjectSubMemberAsgmt>();
            return obj;
        }

        public async Task<List<ProjectSubMemberAsgmt>> GetAllMemberAssignment() //get all member assignment
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/ProjectSubMemberAsgmt");

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectSubMemberAsgmt>>();
            return obj;
        }

        public async Task<List<MemberAsgmtawardedHistory>> GetAllMemberAwarded() //get all awarded member assignment
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/MemberAssignmentAwaredHistory");

            var obj = await response.Content.ReadFromJsonAsync<List<MemberAsgmtawardedHistory>>();
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

        public async Task<ProjectSubProjectTl> SaveSubProject(ProjectSubProjectTl subproject) //save member assign data
        {
            HttpClient hc = new HttpClient();
            var json = JsonConvert.SerializeObject(subproject);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await hc.PostAsync("https://taraapi.ddns.net/api/ProjectSubProjectTl/", data);

            var result = await response.Content.ReadFromJsonAsync<ProjectSubProjectTl>();
            return result;
        }

        public async Task<ProjectSubMemberAsgmt> SaveMemberAssign(ProjectSubMemberAsgmt assign) //save member assign award data
        {
            HttpClient hc = new HttpClient();
            var json = JsonConvert.SerializeObject(assign);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await hc.PostAsync("https://taraapi.ddns.net/api/ProjectSubMemberAsgmt/", data);

            var result = await response.Content.ReadFromJsonAsync<ProjectSubMemberAsgmt>();
            return result;
        }
        #endregion

        #region Module 4
        public async Task<List<MemberMaster>> GetAllMember() //get all member
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/MemberMaster");

            var obj = await response.Content.ReadFromJsonAsync<List<MemberMaster>>();
            return obj;
        }

        public async Task<List<MemberMaster>> GetMemberByID(int id) //get member by id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/MemberMaster/GetById/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<List<MemberMaster>>();
            return obj;
        }

        public async Task<List<MemberMaster>> GetMemberByMemberNo(string numberno) //get member by member no
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/MemberMaster/GetByNo/" + numberno);

            var obj = await response.Content.ReadFromJsonAsync<List<MemberMaster>>();
            return obj;
        }

        public async Task<List<MemberContactPerson>> GetAllContact() //get all contact
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/MemberContactPerson");

            var obj = await response.Content.ReadFromJsonAsync<List<MemberContactPerson>>();
            return obj;
        }

        public async Task<List<MemberContactPerson>> GetContactByMemberNo(string numberno) //get contact by member no
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/MemberContactPerson/GetByMemberNo/" + numberno);

            var obj = await response.Content.ReadFromJsonAsync<List<MemberContactPerson>>();
            return obj;
        }

        public async Task<List<MemberAddress>> GetAddressByMemberNo(string numberno) //get address by member no
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://taraapi.ddns.net/api/MemberAddress/GetByMemberNo/" + numberno);

            var obj = await response.Content.ReadFromJsonAsync<List<MemberAddress>>();
            return obj;
        }

        public async Task<List<MasterTambon>> GetTambonByID(int? id) //get tambon by id (not finish)
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("" + id);

            var obj = await response.Content.ReadFromJsonAsync<List<MasterTambon>>();
            return obj;
        }

        
        #endregion
    }
}
