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
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/ProjectHD/");

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectHd>>();
            return obj;
        }

        public async Task<ProjectHd> GetProjectHDbyID(int id) //get project master data by id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/ProjectHD/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<ProjectHd>();
            return obj;
        }

        public async Task<List<ProjectHd>> GetProjectHDbyProjectName(string name) //get project master data by name
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/ProjectHD/GetByName/" + name);

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectHd>>();
            return obj;
        }

        public async Task<List<ProjectSubProjectTl>> GetProjectSubbySubName(string name) //get project sub by name
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/ProjectSubProjectTl/GetByName/" + name);

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectSubProjectTl>>();
            return obj;
        }

        //public async Task<List<ProjectSubProjectTl>> GetProjectSubProjectTL() //get project sub by project master id
        //{
        //    HttpClient hc = new HttpClient();
        //    var response = await hc.GetAsync("http://119.59.114.151:8001/api/ProjectSubProjectTl/");

        //    var obj = await response.Content.ReadFromJsonAsync<List<ProjectSubProjectTl>>();
        //    return obj;
        //}

        public async Task<ProjectSubProjectTl> GetProjectSubProjectTLbyID(int id) //get project sub by project master id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/ProjectSubProjectTl/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<ProjectSubProjectTl>();
            return obj;
        }

        public async Task<List<RatypeMaster>> GetRATypeMaster() //get all RA Type master data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/RatypeMaster/");

            var obj = await response.Content.ReadFromJsonAsync<List<RatypeMaster>>();
            return obj;
        }

        //public async Task<List<ProjectDocument>> GetAllProjectDocument() //get all project document data
        //{
        //    HttpClient hc = new HttpClient();
        //    var response = await hc.GetAsync("http://119.59.114.151:8001/api/ProjectDocument");

        //    var obj = await response.Content.ReadFromJsonAsync<List<ProjectDocument>>();
        //    return obj;
        //}

        public async Task<List<ProjectDocument>> GetProjectDocumentByProjectSubID(int id) //get project document by project sub id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/ProjectDocument/GetProjectDocBySubId/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectDocument>>();
            return obj;
        }

        public async Task<List<ProjectRatypeTl>> GetAllProjectRAType() //get all project RA type data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/ProjectRatypeTl");

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectRatypeTl>>();
            return obj;
        }

        public async Task<ProjectRatypeTl> GetProjectRATypeBySubProjectID(int id) //get project RA type data by sub project id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/ProjectRatypeTl/GetByProjectSubProjectTLID/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<ProjectRatypeTl>();
            return obj;
        }

        public async Task<ProjectSubMemberAsgmt> GetMemberAssign(int id) //get member assignment data by id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/ProjectSubMemberAsgmt/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<ProjectSubMemberAsgmt>();
            return obj;
        }

        //public async Task<List<ProjectSubMemberAsgmt>> GetAllMemberAssignment() //get all member assignment
        //{
        //    HttpClient hc = new HttpClient();
        //    var response = await hc.GetAsync("http://119.59.114.151:8001/api/ProjectSubMemberAsgmt");

        //    var obj = await response.Content.ReadFromJsonAsync<List<ProjectSubMemberAsgmt>>();
        //    return obj;
        //}

        public async Task<List<ProjectSubMemberAsgmt>> GetMemberAssignmentBySubID(int id) //get member assignment by project sub id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/ProjectSubMemberAsgmt/GetProjectSubMemberBySubId/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectSubMemberAsgmt>>();
            return obj;
        }

        //public async Task<List<MemberAsgmtawardedHistory>> GetAllMemberAwarded() //get all awarded member assignment
        //{
        //    HttpClient hc = new HttpClient();
        //    var response = await hc.GetAsync("http://119.59.114.151:8001/api/MemberAssignmentAwaredHistory");

        //    var obj = await response.Content.ReadFromJsonAsync<List<MemberAsgmtawardedHistory>>();
        //    return obj;
        //}

        public async Task<ProjectHd> SaveProjectHD(ProjectHd projecthd) //save all data
        {
            HttpClient hc = new HttpClient();
            var json = JsonConvert.SerializeObject(projecthd);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await hc.PostAsync("http://119.59.114.151:8001/api/ProjectHD/", data);

            var result = await response.Content.ReadFromJsonAsync<ProjectHd>();
            return result;
        }

        public async Task<ProjectSubProjectTl> SaveSubProject(ProjectSubProjectTl subproject) //save member assign data
        {
            HttpClient hc = new HttpClient();
            var json = JsonConvert.SerializeObject(subproject);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await hc.PostAsync("http://119.59.114.151:8001/api/ProjectSubProjectTl/", data);

            var result = await response.Content.ReadFromJsonAsync<ProjectSubProjectTl>();
            return result;
        }

        public async Task<ProjectSubMemberAsgmt> SaveMemberAssign(ProjectSubMemberAsgmt assign) //save member assign award data
        {
            HttpClient hc = new HttpClient();
            var json = JsonConvert.SerializeObject(assign);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await hc.PostAsync("http://119.59.114.151:8001/api/ProjectSubMemberAsgmt/", data);

            var result = await response.Content.ReadFromJsonAsync<ProjectSubMemberAsgmt>();
            return result;
        }
        #endregion


        #region Module 4
        public async Task<List<MasterCapabilityCat>> GetAllCapability() //get all project RA type data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/MasterCapabilityCat");

            var obj = await response.Content.ReadFromJsonAsync<List<MasterCapabilityCat>>();
            return obj;
        }

        public async Task<List<MasterCapabilityCatSub>> GetAllSubCapability() //get all project RA type data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/MasterCapabilityCatSub");

            var obj = await response.Content.ReadFromJsonAsync<List<MasterCapabilityCatSub>>();
            return obj;
        }

        public async Task<List<MemberMaster>> GetAllMember() //get all member
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/MemberMaster");

            var obj = await response.Content.ReadFromJsonAsync<List<MemberMaster>>();
            return obj;
        }

        public async Task<MemberMaster> GetMemberByID(int id) //get member by id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/MemberMaster/GetById/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<MemberMaster>();
            return obj;
        }

        //public async Task<MemberMaster> GetMemberByMemberNo(string numberno) //get member by member no
        //{
        //    HttpClient hc = new HttpClient();
        //    var response = await hc.GetAsync("http://119.59.114.151:8001/api/MemberMaster/GetByNo/" + numberno);

        //    var obj = await response.Content.ReadFromJsonAsync<MemberMaster>();
        //    return obj;
        //}

        public async Task<List<MemberMaster>> GetMemberByContain(string engname) //get member by contain english name
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/MemberMaster/GetByCompanyName/" + engname);

            var obj = await response.Content.ReadFromJsonAsync<List<MemberMaster>>();
            return obj;
        }

        //public async Task<List<MemberContactPerson>> GetAllContact() //get all contact
        //{
        //    HttpClient hc = new HttpClient();
        //    var response = await hc.GetAsync("http://119.59.114.151:8001/api/MemberContactPerson");

        //    var obj = await response.Content.ReadFromJsonAsync<List<MemberContactPerson>>();
        //    return obj;
        //}

        public async Task<List<MemberContactPerson>> GetContactByMemberNo(string numberno) //get contact by member no
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/MemberContactPerson/GetByMemberNo/" + numberno);

            var obj = await response.Content.ReadFromJsonAsync<List<MemberContactPerson>>();
            return obj;
        }

        public async Task<List<MemberAddress>> GetAddressByMemberNo(string numberno) //get address by member no
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/MemberAddress/GetByMemberNo/" + numberno);

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

        public async Task<List<User>> GetAllUser() //get all user
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/User");

            var obj = await response.Content.ReadFromJsonAsync<List<User>>();
            return obj;
        }

        public async Task<List<Customer>> GetCustomerByContain(string cusname)
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/Customer/GetByName/" + cusname);

            var obj = await response.Content.ReadFromJsonAsync<List<Customer>>();
            return obj;
        }

        public async Task<List<MemberCategory>> GetAllMemberCategory() //get all member category
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("http://119.59.114.151:8001/api/MemberCategory");

            var obj = await response.Content.ReadFromJsonAsync<List<MemberCategory>>();
            return obj;
        }
        #endregion
    }
}
