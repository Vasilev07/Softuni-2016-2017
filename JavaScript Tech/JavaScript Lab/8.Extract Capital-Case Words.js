/**
* Created by Georgi Vasilev on 3/23/2017.
*/

function solve(args) {
   let text = args.join(",");
   let words = text.split(/\W+/);
   let nonEmptyWords = words.filter(w=> w.length > 0);
   let upWords = nonEmptyWords.filter(isUppercase);
   console.log(upWords.join(", "));
   
   function isUppercase(args) {
       return args == args.toUpperCase();
   }
}
//HTML, CSS, JSON, REST, PHP, SQL, EF, SQL, ASP, NET, MVC, MVC
//HTML, CSS, JSON, REST, PHP, SQL, C, EF, SQL, ASP, NET, MVC, MVC
solve(["We start by HTML, CSS, JavaScript, JSON and REST.Later we touch some PHP, MySQL and SQL.Later we play with C#, EF, SQL Server and ASP.NET MVC.Finally, we touch some Java, Hibernate and Spring.MVC."]);