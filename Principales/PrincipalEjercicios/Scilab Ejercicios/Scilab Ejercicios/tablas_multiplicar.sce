n=10;
A = zeros(n,n);
for j = 1:n
 for k=1:n
 A(j,k) = j*k;
 end
end
disp(A)
