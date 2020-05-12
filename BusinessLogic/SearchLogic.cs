using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Logic
{
    public class SearchLogic
    {
        dbManager myDbManager; //declare dbManager
        DataSet data;
        string queryString;

        public SearchLogic()
        {
            myDbManager = new dbManager(); // initialize 
            queryString = "SELECT * FROM ";
        }
        public DataSet test()
        {
            data = myDbManager.QueryDatabase("SELECT * FROM TabUser");

            return data;
        }
        public DataSet getBooksBy(string userChoice)
        {

            switch (userChoice)
            {
                case "Title":
                    data = myDbManager.QueryDatabase("SELECT BookName FROM TabBook");
                    return data;
                case "Published Year":
                    data = myDbManager.QueryDatabase("SELECT PublishYear FROM TabBook");
                    return data;
                case "Language":
                    data = myDbManager.QueryDatabase("SELECT Language FROM TabBook");
                    return data;
                case "Author":
                    data = myDbManager.QueryDatabase("SELECT * FROM TabAuthor");
                    return data;
                case "Category":
                    data = myDbManager.QueryDatabase("SELECT * FROM TabCategory");
                    return data;
            }
            return null;

        }
        private static string composeSqlString(string userChoice)
        {
            return "SELECT * FROM " + userChoice;
        }

    }
}
