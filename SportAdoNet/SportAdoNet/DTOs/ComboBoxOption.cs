namespace SportAdoNet.DTOs
{
    public class ComboBoxOption
    {
        public string Nome { get; set; }
        public bool? Value { get; set; }

        public ComboBoxOption(string nome, bool? value)
        {
            Nome = nome;
            Value = value;
        }
    }
}
