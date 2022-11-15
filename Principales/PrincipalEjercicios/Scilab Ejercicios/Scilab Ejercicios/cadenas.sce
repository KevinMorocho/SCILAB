printf("Ingrese una cadena: "),
cadena=input('.',"string");
n=length(cadena);
pi=1;
pf=0;
k=1;
for i = 1:n
  p=part(cadena,i);
  if (p==' ')then
      pf=i-1;
      convoc=0;
        for j=pi:pf
            n=part(cadena,j);
            n=convstr(n,"u")
           if(n=='A')|(n=='E')|(n=='I')|(n=='O')|(n=='U')
               convoc=convoc+1;
           end;
        end
        y(k)=convoc;
        printf('Palabra %d  =  %d \n',k,convoc);
        k=k+1;
        pi=i+1;
   end; 
 end;
k=k-1;
x=[1:k];
for h=1:k
    printf('X=  %d ',x(h));  
    printf('Y=  %d ',y(h))
end
plot(x,y);

