using System;
using System.IO;

class row{
  private int n_slots;
  private List slots;

  public row(int n_s){
    slots= new List();
    n_slots=n_s;
    for(int i=0;i<n_s;i++){
      slots.add("");
    }
  }

  public void addUnavailable(int pos){
    slots.Insert(pos,"unavailable");
  }

  public bool IsUnavailable(int pos){
    if (slots[pos]="unavailable"){
      return true;
    }
    else{
      return false;
    }
  }

  public bool IsValid(int pos){
    if (slots[pos]=""){
      return true;
    }
    else{
      return false;
    }
  }
  public bool enter(int pos,int size){
    int ac=0;
    for (int i=pos;i<slots.size() && ac!=size ;i++){
      if(IsUnavailable(i)){break;}
      ac++;
    }


  if(ac==size){return true;}
  else{return false;}
  }

}


class center{
  private int n_row;
  private int n_slot;
  private int n_unvaliable;
  private int n_pool;
  private int n_server;

  public center(int n_r,int n_s,int n_u,int n_p,int n_se){
    n_row=n_r;
    n_slot=n_s;
    n_unvaliable=n_u;
    n_pool=n_p;
    n_server=n_se;
  }
  public center(String s){
    String[] substrings = s.Split(' ');
    n_row=Int32.Parse(substrings[0]);
    n_slot=Int32.Parse(substrings[1]);
    n_unvaliable=Int32.Parse(substrings[2]);
    n_pool=Int32.Parse(substrings[3]);
    n_server=Int32.Parse(substrings[4]);
  }

  public override string ToString(){
    return (n_row.ToString()+" "+n_slot.ToString()+" "+n_unvaliable.ToString()+" "+n_pool.ToString()+" "+n_server.ToString());
  }

}

class main{
    public static void Main(){
        try{
            // Open the text file using a stream reader.
            using (StreamReader sr = new StreamReader("dc.in")){
                String first_line=sr.ReadLine();
                center c=new center(first_line);
                Console.WriteLine(c.ToString());
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                Console.WriteLine(line+" esto es una linea");
            }
        }
        catch (Exception e){
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}
