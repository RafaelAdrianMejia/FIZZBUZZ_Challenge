//Write a public method that accepts a number
      //1.Access Modifier
      //2.Return Type
      //3.Method Name
      //4.Parameters
      //5.Scope


public string FizzBuzz(int number)
{
    var answer = "";

    //when the number is divisible by 3 return the word FIZZ

    if(number % 3 == 0)
    {
        answer = "FIZZ";
    }
    
    if(number % 5 == 0)
    {
        answer += "BUZZ"; //answer = answer + "BUZZ"
    }
    
    return answer;

    //when the number is divisible by 5 return the word BUZZ

    //when the number is divisible by both, return the word FIZZBUZZ

}

