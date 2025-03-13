using System;
using System.Collections.Generic;

public static class UserStore
{
    public class UserData
    {
        public string Password { get; set; }
        public int TDEE { get; set; }
        public string Goal { get; set; }
        public List<double> WeightHistory { get; set; } = new List<double>();
    }

    private static Dictionary<string, UserData> Users = new Dictionary<string, UserData>();

    public static bool AddUser(string username, string password, int tdee, string goal, double initialWeight)
    {
        if (Users.ContainsKey(username)) return false;

        Users[username] = new UserData
        {
            Password = password,
            TDEE = tdee,
            Goal = goal,
            WeightHistory = new List<double> { initialWeight }
        };
        return true;
    }

    public static UserData GetUser(string username)
    {
        return Users.TryGetValue(username, out UserData user) ? user : null;
    }

    public static bool ValidateUser(string username, string password)
    {
        return Users.TryGetValue(username, out UserData user) && user.Password == password;
    }

    public static void UpdateWeight(string username, double newWeight)
    {
        if (Users.ContainsKey(username))
        {
            Users[username].WeightHistory.Add(newWeight);
        }
    }
}
