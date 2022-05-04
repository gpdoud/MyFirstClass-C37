using MyFirstClass;

var evan = new TqlStudent("Evan", "Mercurio", 5);
var evangit = new Assessment() {
    Topic = "Git/GitHub", Points = 110, Taken = DateTime.Now
};
evan.GitGithubAssessment = evangit;

evan.HappyAnniversary();

Console.WriteLine(evan.Print());

var greg = new TqlStudent("Greg", "Doud", 0);

Console.WriteLine(greg.Print());

var git = new Assessment() { Topic = "Git/GitHub", Points = 110, Taken = DateTime.Now };
var sql = new Assessment() { Topic = "SQL", Points = 110, Taken = DateTime.Now };
var test = new TqlStudent() {
    Firstname = "Test", YearsOfService = 99, GitGithubAssessment = git
};
test.SqlAssessment = sql;

Console.WriteLine(test.Print());


