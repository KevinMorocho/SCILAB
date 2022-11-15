printf("Tamaño matriz???");
n=input(".");
for i = 1:n
    for j = 1:n
        mat(i,j)=input("elemento: ");
    end    
end

disp("Diagonal matriz 1");
for i = 1:n
    disp(mat(1,i))
end

disp("Diagonal matriz 2");
for i = 1:n
    disp(mat(i,1))
end


disp("Diagonal matriz 3");
for i = 1:n
    disp(mat(i,i))
end
