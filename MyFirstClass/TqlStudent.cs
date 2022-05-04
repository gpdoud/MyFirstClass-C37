using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass {

    internal class TqlStudent {

        private static int NextId = 1;

        public int Id { get; set; } = 0;
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public int YearsOfService { get; set; } = 0;
        public Assessment? GitGithubAssessment { get; set; } = null;
        public Assessment? SqlAssessment { get; set; } = null;
        

        public string Print() {
            var msg = $"{Id}: {Fullname()} has {YearsOfService} year{(YearsOfService > 1 ? "s" : "")} of service at TQL.";
            if(GitGithubAssessment is not null) {
                msg = msg + $"\nAssessment {GitGithubAssessment!.Topic}, Points: {GitGithubAssessment.Points}";
            }            
            if(SqlAssessment is not null) {
                msg = msg + $"\nAssessment {SqlAssessment!.Topic}, Points: {SqlAssessment.Points}";
            }
            return msg;
        }
        public string Fullname() {
            return $"{this.Firstname} {Lastname}";
        }
        public void HappyAnniversary() {
            YearsOfService++;
        }

        public TqlStudent(string firstname, string lastname, int yearsOfService) {
            Firstname = firstname;
            this.Lastname = lastname;
            this.YearsOfService = yearsOfService;
            Id = NextId++;
        }
        public TqlStudent() {
            Id = NextId++;
        }

    }
}
