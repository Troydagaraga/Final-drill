using System;
using System.Collection.Generic;
using System.Ling;

class student{
  public string StudentNumber { get;set; }
  public string Surname { get;set; }
  public string Firstname { get; set; }
  public string Occupation { get; set; }
  public string Gender { get; set; } 
  public int CountryCode { get; set; }
  public string AreaCode { get; set; }
  public string PhoneNumber { get; set; }

  public Student(string studentNumber, string surname,string firstName,string occupation,string gender,int countryCode,string areaCode,string phoneNumber)
  {
    StundentNumber = StudentNumber;
    Surname = surname;
    Firstname = firstName;
    Occupation = occupation;
    Gender = gender;
    CountryCode = countryCode;
    AreaCode = areaCode;
    PhoneNumber = phoneNumber;
  }

  public void Diplay()
  {
    Console.Write(
      $"{Surname}, {Firstname}, with stundent number" +
      $"{StudentNUmber}, is a {Occupation}, "+
      $
