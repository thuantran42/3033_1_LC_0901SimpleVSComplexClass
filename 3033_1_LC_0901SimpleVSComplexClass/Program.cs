//  Thuan (Trae) Tran ID: 113437456
// Sept 1 Lecture Code MIS 3033 001
// Simple Vs Complex variables, Class

// simple: int, bool, double, char
// complex: string
// 
// datatype variable_name;

//double _stuWeightDouble; // people usually name it double or dbl at the end to remind its a dobule
//_stuWeightDouble = 120.8; //101 (you got a value into that room)

//double _stuWeightDouble2;
//_stuWeightDouble2 = _stuWeightDouble; // copies the value of this room (content)

//string _stuNameStr; // (room card) you don't get a room yet
////_stuNameStr = "Trae Tran";
//// new Datatype(...)
//_stuNameStr = new string("Trae Tran"); // mew room with a room number (102)
//// assignment copies

//string _stuNameStr2; // (2nd room card)
//_stuNameStr2 = _stuNameStr; // copies the location number of the room


// Define new datatype using class
// complex

Person p1;
p1 = new Person(); // syntax to create a new object
p1.name = new string("Trae Tran"); // name is a complex datatype, just a room card
p1.name = "Trae Tran"; // same as new string("Trae Tran");
p1.age = 22; // age is a simple datatype , so it has a room number
p1.weight = 120.8;

string infoStr = p1.GetPersonInfor();
Console.WriteLine(infoStr);

Console.ReadLine();
//class DatatypeName
//{

//}

public class Person // by default, it's private, so type public next to it make it public
{
    public string name;
    public int age;
    public double weight;

    public string GetPersonInfor()
    {
        string personInfoStr = string.Format($"The name is {name} \n The age is {age} \n The weight is {weight:F2}");
        return personInfoStr;
    }

    // datatype function_name() 
    // {
    // ..
    // return;
    // }
}





