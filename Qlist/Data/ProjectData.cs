using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core.Tokenizer;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Qlist.ModelM2s;
using Qlist.ModelM4s;

namespace Qlist.Data
{
    public class ProjectData
    {
        string ip = "http://apim2.theworkpc.com/api/";   //Production
        string header = "";

        #region Module 2
        public async Task<List<ProjectHd>> GetProjectHD() //get all project master data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "ProjectHD/");

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectHd>>();
            return obj;
        }

        public async Task<ProjectHd> GetProjectHDbyID(int id) //get project master data by id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "ProjectHD/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<ProjectHd>();
            return obj;
        }

        public async Task<List<ProjectHd>> GetProjectHDbyProjectName(string name) //get project master data by name
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "ProjectHD/GetByName/" + name);

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectHd>>();
            return obj;
        }

        public async Task<List<ProjectSubProjectTl>> GetProjectSubbySubName(string name) //get project sub by name
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "ProjectSubProjectTl/GetByName/" + name);

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectSubProjectTl>>();
            return obj;
        }

        public async Task<ProjectSubProjectTl> GetProjectSubProjectTLbyID(int id) //get project sub by project master id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "ProjectSubProjectTl/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<ProjectSubProjectTl>();
            return obj;
        }

        public async Task<List<RatypeMaster>> GetRATypeMaster() //get all RA Type master data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "RatypeMaster/");

            var obj = await response.Content.ReadFromJsonAsync<List<RatypeMaster>>();
            return obj;
        }

        public async Task<List<ProjectDocument>> GetProjectDocumentByProjectSubID(int id) //get project document by project sub id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "ProjectDocument/GetProjectDocBySubId/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectDocument>>();
            return obj;
        }

        public async Task<List<ProjectRatypeTl>> GetAllProjectRAType() //get all project RA type data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "ProjectRatypeTl");

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectRatypeTl>>();
            return obj;
        }

        public async Task<ProjectRatypeTl> GetProjectRATypeBySubProjectID(int id) //get project RA type data by sub project id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "ProjectRatypeTl/GetByProjectSubProjectTLID/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<ProjectRatypeTl>();
            return obj;
        }

        public async Task<ProjectSubMemberAsgmt> GetMemberAssign(int id) //get member assignment data by id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "ProjectSubMemberAsgmt/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<ProjectSubMemberAsgmt>();
            return obj;
        }

        public async Task<List<ProjectSubMemberAsgmt>> GetAllMemberAssignment() //get all member assignment
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "ProjectSubMemberAsgmt");

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectSubMemberAsgmt>>();
            return obj;
        }

        public async Task<List<ProjectSubMemberAsgmt>> GetMemberAssignmentBySubID(int id) //get member assignment by project sub id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "ProjectSubMemberAsgmt/GetProjectSubMemberBySubId/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<List<ProjectSubMemberAsgmt>>();
            return obj;
        }

        public async Task<List<Tickets>> GetAllTicket() //get all ticket data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "Ticket");

            var obj = await response.Content.ReadFromJsonAsync<List<Tickets>>();
            return obj;
        }

        public async Task<Tickets> GetTicketByNO(int no) //get ticket data by no.
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "Ticket/" + no.ToString());

            var obj = await response.Content.ReadFromJsonAsync<Tickets>();
            return obj;
        }

        public async Task<List<Event>> GetEventbySubProjectID(int id) //get event data by sub id.
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "Event/GetByProjectSubProjectTLID/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<List<Event>>();
            return obj;
        }

        public async Task<ProjectHd> SaveProjectHD(ProjectHd projecthd) //save all data
        {
            HttpClient hc = new HttpClient();
            var json = JsonConvert.SerializeObject(projecthd);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await hc.PostAsync(ip + "ProjectHD/", data);

            var result = await response.Content.ReadFromJsonAsync<ProjectHd>();
            return result;
        }

        public async Task<ProjectSubProjectTl> SaveSubProject(ProjectSubProjectTl subproject) //save member assign data
        {
            HttpClient hc = new HttpClient();
            var json = JsonConvert.SerializeObject(subproject);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await hc.PostAsync(ip + "ProjectSubProjectTl/", data);

            var result = await response.Content.ReadFromJsonAsync<ProjectSubProjectTl>();
            return result;
        }

        public async Task<ProjectSubMemberAsgmt> SaveMemberAssign(ProjectSubMemberAsgmt assign) //save member assign award data
        {
            HttpClient hc = new HttpClient();
            var json = JsonConvert.SerializeObject(assign);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await hc.PostAsync(ip + "ProjectSubMemberAsgmt/", data);

            var result = await response.Content.ReadFromJsonAsync<ProjectSubMemberAsgmt>();
            return result;
        }

        public async Task<Tickets> SaveTicket(Tickets ticket) //save all data
        {
            HttpClient hc = new HttpClient();
            var json = JsonConvert.SerializeObject(ticket);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await hc.PostAsync(ip + "Ticket/", data);

            var result = await response.Content.ReadFromJsonAsync<Tickets>();
            return result;
        }

        public async Task<Event> SaveEvent(Event eve) //save all data
        {
            HttpClient hc = new HttpClient();
            var json = JsonConvert.SerializeObject(eve);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await hc.PostAsync(ip + "Event", data);

            var result = await response.Content.ReadFromJsonAsync<Event>();
            return result;
        }

        public async Task<ProjectSubMemberAsgmt> DeleteAssign(int id)
        {
            HttpClient hc = new HttpClient();
            var response = await hc.DeleteAsync(ip + "ProjectSubMemberAsgmt/" + id.ToString());

            var result = await response.Content.ReadFromJsonAsync<ProjectSubMemberAsgmt>();
            return result;
        }

        public async Task<MemberAsgmtawardedHistory> DeleteAwarded(int id)
        {
            HttpClient hc = new HttpClient();
            var response = await hc.DeleteAsync(ip + "MemberAssignmentAwaredHistory/" + id.ToString());

            var result = await response.Content.ReadFromJsonAsync<MemberAsgmtawardedHistory>();
            return result;
        }

        public async Task DeleteDoc(int id)
        {
            HttpClient hc = new HttpClient();
            var response = await hc.DeleteAsync(ip + "ProjectDocument/" + id.ToString());
        }
        #endregion


        #region Module 4
        public async Task<List<MasterCapabilityCat>> GetAllCapability() //get all project RA type data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "MasterCapabilityCat");

            var obj = await response.Content.ReadFromJsonAsync<List<MasterCapabilityCat>>();
            return obj;
        }

        public async Task<List<MasterCapabilityCatSub>> GetAllSubCapability() //get all project RA type data
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "MasterCapabilityCatSub");

            var obj = await response.Content.ReadFromJsonAsync<List<MasterCapabilityCatSub>>();
            return obj;
        }

        public async Task<List<MemberMaster>> GetAllMember() //get all member
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "MemberMaster");

            var obj = await response.Content.ReadFromJsonAsync<List<MemberMaster>>();
            return obj;
        }

        public async Task<MemberMaster> GetMemberByID(int id) //get member by id
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "MemberMaster/GetById/" + id.ToString());

            var obj = await response.Content.ReadFromJsonAsync<MemberMaster>();
            return obj;
        }

        public async Task<List<User>> GetAllUser() //get all user
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "User");

            var obj = await response.Content.ReadFromJsonAsync<List<User>>();
            return obj;
        }

        public async Task<List<MemberCategory>> GetAllMemberCategory() //get all member category
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync(ip + "MemberCategory");

            var obj = await response.Content.ReadFromJsonAsync<List<MemberCategory>>();
            return obj;
        }
        #endregion
    }
}
