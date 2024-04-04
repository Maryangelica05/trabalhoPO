namespace TrabalhoPo;

public class Personagem
{
   protected double sede;
   protected  double fome;
   protected double  banho;
   protected string arquivo;
   protected string arquivomorto;
   protected bool morto; 

   public Personagem()
   {
      sede=0.5;
   
      fome=0.5;

      banho=0.5;
   }

   public void SetFome( double f)
   {
      if (f<=1 && f>=0)
         fome=f;
      else if(f > 1)
         fome=1;
      else {
         morto = true;
         fome=0;
      }
   }

   public  double GetFome()
   {
      return fome;
   }
   public void SetSede( double s)
   {
      if (s<=1&& s>=0)
         sede=s;
      else if(s > 1)
         sede=1;
      else 
       {
         morto = true;
         sede=0;
      }
        
   }

   public  double GetSede()
   {
      return sede;
   }
   public void SetBanho( double b)
   {
      if (b<=1 && b>=0)
         banho=b;
      else if(b > 1)
         banho=1;
      else 
      {
         morto = true;
         banho=0;
      }
   }

   public  double GetBanho()
   {
      return banho;
   }

   public string GetArquivo()
   {
      if(morto)
      return arquivomorto;
      else 
      return arquivo;
   }
}

