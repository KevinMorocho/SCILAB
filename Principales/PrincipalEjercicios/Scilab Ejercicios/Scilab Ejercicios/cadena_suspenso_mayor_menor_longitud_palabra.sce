clc
printf('Escriba la frase a consultar\n');
frase=input(' ','string');
n=length(frase)
band=0;
conti=1;
for i=1:length(frase)
    cad(i)=part(frase,i);
end
cad(n+1)=' ';
cont=0;
cont_may=0;
cont_men=20;
for i=1:n+1
    if(cad(i)<>' ')then
        cont=cont+1;        
    end
    if(cad(i)==' ')then
        inicio=i-cont;
        fin=i-1;
        //printf("\nincio %s",cad(inicio));
        //printf("\nfinal %s\n",cad(fin));
        lon=(fin+1)-inicio;
        lonM=(fin+1)-inicio; 
        if(lon>cont_may)
            imay=inicio;
            fmay=fin; 
        end
        if(lonM<cont_men)
            cont_men=lon;
            imen=inicio;
            fmen=fin; 
        end
        lon=0;
        cont=0; 
    end
end
printf("\nLa palabra mas grande es: ");
for x=imay:fmay
    printf("%s",cad(x)," ");
end
printf("\nLa palabra mas pequenia es: ");
for x=imen:fmen
    printf("%s",cad(x)," ");
end
//La amistad hace iguales a los amigos
