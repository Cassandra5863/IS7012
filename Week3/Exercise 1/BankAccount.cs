public class BankAccount {
  public string AccountNumber { get; set; }
  public decimal CurBalance { get; set; }
  public string AccountName { get; set; }
  public string AccountType { get; set; }
  public DateTime CreationDate { get; set; }
  public AccountHolder? AccountHolder { get; set; }
}
