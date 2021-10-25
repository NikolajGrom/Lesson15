using System;
class User
{
    public  string Name{get; set;}
    public string SName{get; set;}
    public int Age {get; set;}
    public User()
    {
    
    }
    public User(string Name, string SName, int Age)
    {
        this.Name = Name;
        this.SName = SName;
        this.Age = Age;
    }
    public override string ToString()
    {
      return String.Format("Имя:{0}\nФамилия: {1}\nВозраст: {2}\n", this.Name, this.SName, this.Age );
    }

}