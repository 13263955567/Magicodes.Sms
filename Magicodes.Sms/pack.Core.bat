echo �������ַ���
echo %1
echo ��Ŀ������ַ
echo %2

echo ɾ����ʷ��
del %1 /f /q /a 

echo ������
set nupkg=""

echo ���
nuget Pack %2 -Build -symbols -Properties Configuration=Release

echo ���°�����

for %%a in (dir /s /a /b "./%1") do (set nupkg=%%a)

echo ���Ͱ�
nuget push %nupkg% 4e3f500e-a031-45fa-b746-5762275e7561 -Source https://www.nuget.org/api/v2/package