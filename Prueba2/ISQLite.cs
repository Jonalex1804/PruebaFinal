using SQLite;
namespace ChuckNorrisJokes

{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}