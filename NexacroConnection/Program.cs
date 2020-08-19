using Nexacro17.Xapi.Data;
using Nexacro17.Xapi.Tx;
using System;
public partial class XAPI_TEST : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // HttpRequest를 이용하여 PlatformRequest 생성
        PlatformRequest req = new PlatformRequest(Request.InputStream);
      
        // 데이터 수신
        req.ReceiveData();

        // 수신받은 데이터 획득
        PlatformData reqData = req.GetData();
        VariableList reqVarList = reqData.GetVariableList();

        // 부서명 획득
        string name = reqVarList.GetString("name");

        // 송신할 데이터 생성
        PlatformData resData = new PlatformData();
        VariableList resVarList = resData.GetVariableList();

        // 부서별 인원을 저장할 DataSet 생성
        DataSet employees = new DataSet("employees");

        // DataSet에 열(column) 추가
        employees.AddColumn(new ColumnHeader("name", DataTypes.STRING, 8));
        employees.AddColumn(new ColumnHeader("jobTitle", DataTypes.STRING));
        employees.AddColumn(new ColumnHeader("number", DataTypes.INT));
        employees.AddColumn(new ColumnHeader("manager", DataTypes.BOOLEAN));

        // 부서별 인원 데이터 추가
        if ("R&D Center".Equals(name))
        {
            // 행(row) 추가
            int row = employees.NewRow();
            // 추가된 행(row)의 데이터 설정
            employees.Set(row, "name", "John Jones");
            employees.Set(row, "jobTitle", "developer");
            employees.Set(row, "number", 1234);
            employees.Set(row, "manager", false);
            // ...
            // 정상 수행
            resData.AddDataSet(employees);
            resVarList.Add("ERROR_CODE", 200);
        }
        else if ("Quality Assurance".Equals(name))
        {
            // 행(row) 추가
            int row = employees.NewRow();
            // 추가된 행(row)의 데이터 설정
            employees.Set(row, "name", "Tom Glover");
            employees.Set(row, "jobTitle", "manager");
            employees.Set(row, "number", 9876);
            employees.Set(row, "manager", true);
            // ...
            // 정상 수행
            resData.AddDataSet(employees);
            resVarList.Add("ERROR_CODE", 200);
        }
        else
        {
            // 오류 발생
            resVarList.Add("ERROR_CODE", 500);
        }
        // HttpServletResponse를 이용하여 PlatformResponse 생성
        PlatformResponse res = new PlatformResponse(Response.OutputStream);
        res.SetData(resData);
        // 데이터 송신
        res.SendData();
    }
}