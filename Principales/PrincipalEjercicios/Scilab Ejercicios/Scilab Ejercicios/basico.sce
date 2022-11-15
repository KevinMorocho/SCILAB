Z=['a','o','c';'x','e','i']; 
s=0; s1=0; s2=0; s3=0; s4=0; 
for i = 1:2 
    for j=1:3 n=Z(i,j) 
        n= convstr(n,"u") 
       select n
           if (n=='A') then 
           s=s+1;
                  if (n=='A') then 
           s=s+1;
                  if (n=='A') then 
           s=s+1;
                  if (n=='A') then 
           s=s+1;
       else
           
       break
    end 
end 
disp("LETRA A"); disp(s); disp("LETRA E"); disp(s1); disp("LETRA I"); disp(s2); disp("LETRA O"); disp(s3); disp("LETRA U"); disp(s4); 
