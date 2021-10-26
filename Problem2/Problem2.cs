public class Kata
{
  public static bool Check(object[] a, object x)
  { // function is a bool, returning true or false
    // var a is an array of objects, 
    foreach (object i in a)
      { // note 1: difference in == and .Equals()
      if (i.Equals(x))
        {
        return true;
      }
    } // the false return has to be outside the loop to be picked up, part of the build step.
    return false;
  }
}

// // Problem from https://www.codewars.com/kata/57cc975ed542d3148f00015b/train/csharp

// // note 1: https://stackoverflow.com/questions/814878/c-sharp-difference-between-and-equals
// // https://docs.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-5.0