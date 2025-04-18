namespace WebApplication5
{
    public class SupaBaseContext
    {
        public SupaBaseContext()
        {
        }

        public async Task<List<User>> GetUsers(Supabase.Client _supabaseClient)
        {
            var result = await _supabaseClient.From<User>().Get();
            return result.Models;
        }
    }
}