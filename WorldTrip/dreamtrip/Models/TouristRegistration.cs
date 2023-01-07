namespace mytrip;
[Serializable]

public class Tourist{

    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string EmailId{get;set;}
    public string Password{get;set;}

    public Tourist():base(){
        
    }
    public Tourist(string fname,string lname,string email,string password)
    {
        this.FirstName = fname;
        this.LastName = lname;
        this.EmailId = email;
        this.Password = password;

    }

}