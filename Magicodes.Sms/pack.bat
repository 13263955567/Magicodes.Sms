echo �������ַ���
echo %1
echo ��Ŀ������ַ
echo %2

echo ���
nuget Pack %2 -Build -Properties Configuration=Release
echo ���Ͱ�
nuget push %1 -s https://www.nuget.org 4e3f500e-a031-45fa-b746-5762275e7561