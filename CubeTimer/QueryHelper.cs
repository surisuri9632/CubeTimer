using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CubeTimer
{
    /// <summary>
    /// 쿼리 헬퍼 클래스 입니다.
    /// </summary>
    public static class QueryHelper
    {
        #region Field

        /// <summary>
        /// 연결 입니다.
        /// </summary>
        private static string _connection = $@"URI=file:{Application.StartupPath}\Record.db";

        #endregion

        #region InsertItem(connection, source) - 항목을 추가합니다.

        /// <summary>
        /// 항목을 추가합니다.
        /// </summary>
        /// <param name="connection">연결 입니다.</param>
        /// <param name="source">소스 입니다.</param>
        public static void InsertItem(SQLiteConnection connection, TimeModel source)
        {
            using(SQLiteCommand command = new SQLiteCommand(connection))
            {
                #region SQL 쿼리를 실행합니다.

                command.CommandText = @"
INSERT INTO TimeRecord
(
    TIME
)
VALUES
(
    @TIME
)
";

                #endregion

                command.Parameters.Add(new SQLiteParameter(@"TIME", DbType.String) { Value = source.Time });

                command.ExecuteNonQuery();
            }
        }

        #endregion
        #region InsertItem(source) - 항목을 추가합니다.

        /// <summary>
        /// 항목을 추가합니다.
        /// </summary>
        /// <param name="source">소스 입니다.</param>
        public static void InsertItem(TimeModel source)
        {
            using(SQLiteConnection connection = new SQLiteConnection(_connection))
            {
                connection.Open();

                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    InsertItem(connection, source);
                }
            }
        }

        #endregion

        #region DeleteItem(time) - 항목을 삭제합니다.

        /// <summary>
        /// 항목 삭제하기
        /// </summary>
        /// <param name="time">time</param>
        public static void DeleteItem(string time)
        {
            using(SQLiteConnection connection = new SQLiteConnection(_connection))
            {
                connection.Open();

                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    #region SQL 쿼리를 실행합니다.

                    command.CommandText = "DELETE FROM TimeRecord WHERE TIME = @TIME";

                    #endregion

                    command.Parameters.Add(new SQLiteParameter(@"TIME", DbType.String) { Value = time });

                    command.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region DeleteAllItem() - 모든 항목을 삭제합니다.

        /// <summary>
        /// 모든 항목을 삭제합니다.
        /// </summary>
        public static void DeleteAllItem()
        {
            using(SQLiteConnection connection = new SQLiteConnection(_connection))
            {
                connection.Open();

                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    #region SQL 쿼리를 실행합니다.

                    command.CommandText = "DELETE FROM TimeRecord";

                    #endregion

                    command.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region GetItem(id) - 항목을 구합니다.

        /// <summary>
        /// 항목을 구합니다.
        /// </summary>
        /// <param name="time">time</param>
        /// <returns>시간 모델 입니다.</returns>
        public static TimeModel GetItem(string time)
        {
            using(SQLiteConnection connection = new SQLiteConnection(_connection))
            {
                connection.Open();

                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    #region SQL 쿼리를 실행합니다.

                    command.CommandText = "SELECT TIME FROM TimeRecord WHERE TIME = @TIME";

                    #endregion

                    command.Parameters.Add(new SQLiteParameter(@"TIME", DbType.String) { Value = time });

                    SQLiteDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        TimeModel item = new TimeModel();

                        item.Time = reader["Time"].ToString();

                        return item;
                    }

                    return null;
                }
            }
        }

        #endregion

        #region GetList(time) - 리스트를 구합니다.

        /// <summary>
        /// 리스트를 구합니다.
        /// </summary>
        public static List<TimeModel> GetList()
        {
            using(SQLiteConnection connection = new SQLiteConnection(_connection))
            {
                connection.Open();

                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    #region SQL 쿼리를 실행합니다.

                    command.CommandText = "SELECT TIME FROM TimeRecord";

                    #endregion

                    SQLiteDataReader reader = command.ExecuteReader();

                    List<TimeModel> list = new List<TimeModel>();

                    while(reader.Read())
                    {
                        TimeModel item = new TimeModel();

                        item.Time = reader["TIME"].ToString();

                        list.Add(item);
                    }

                    return list;
                }
            }
        }

        #endregion
    }
}
