//sebastian

clc
printf('FRASE A VERIFICAR');
texto_fr=input(' ','string');
limi_text=length(texto_fr)
ama_r=0;
conti=1;
a=1;
while a<=length(texto_fr)
    cad(a)=part(texto_fr,a);
    a=a+1;
end
cont=0;
r_p=0;
a=1;
cad(limi_text+1)=' ';
while a<=limi_text+1 
    if(cad(a)<>' ')then
        cont=cont+1;        
    end
    if(cad(a)==' ')then
        ama_r=a-cont;
        conti=ama_r
        r_p=a-1;
        r_t=0;
        r_y=0;
        for tempo=ama_r:a-1
            r_y=r_y+1;
            if ( convstr(cad(tempo),'u') == convstr(cad(r_p),'u') )
                r_t=r_t+1;
            end
            r_p=r_p-1;            
        end        
        if r_t == r_y then
            for tempo=ama_r:a-1
                printf("%s",cad(tempo));
           end            
           printf("\n");
        end
        cont=0;
    end
    a=a+1;
end
