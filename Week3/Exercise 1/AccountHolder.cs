public class AccountHolder {
  public int AccountID { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public DateTime DateOfBirth { get; set; }
  public string Gender { get; set; }
  public string ContactPhone { get; set; }
  public string ContactEmail { get; set; }
  public List<BankAccount>? BankAccounts { get; set; }
}
