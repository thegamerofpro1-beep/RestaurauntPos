Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.CompilerServices

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute>
    Friend NotInheritable Class ModClasses
        Public Shared con As System.Data.SqlClient.SqlConnection

        Public Shared cmd As System.Data.SqlClient.SqlCommand

        Public Shared cmd1 As System.Data.SqlClient.SqlCommand

        Public Shared cmd2 As System.Data.SqlClient.SqlCommand

        Public Shared cmd3 As System.Data.SqlClient.SqlCommand

        Public Shared cmd4 As System.Data.SqlClient.SqlCommand

        Public Shared rdr As System.Data.SqlClient.SqlDataReader

        Public Shared ds As System.Data.DataSet

        Public Shared adp As System.Data.SqlClient.SqlDataAdapter

        Public Shared adp1 As System.Data.SqlClient.SqlDataAdapter

        Public Shared adp2 As System.Data.SqlClient.SqlDataAdapter

        Public Shared adp3 As System.Data.SqlClient.SqlDataAdapter

        Public Shared adp4 As System.Data.SqlClient.SqlDataAdapter

        Public Shared dtable As System.Data.DataTable

        Public Shared dtable1 As System.Data.DataTable

        Public Shared dtable2 As System.Data.DataTable

        Public Shared dtable3 As System.Data.DataTable

        Public Shared dtable4 As System.Data.DataTable

        Public Shared TempFileNames2 As String
    End Class
End Namespace
