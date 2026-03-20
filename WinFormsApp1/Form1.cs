using Lab1;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void ResetValidationState()
    {
        txtNumberOfItems.BackColor = SystemColors.Window;
        txtCapacity.BackColor = SystemColors.Window;
        txtSeed.BackColor = SystemColors.Window;
    }

    private static void MarkInvalid(TextBox textBox)
    {
        textBox.BackColor = Color.MistyRose;
    }

    private bool TryReadInputs(out int numberOfItems, out int capacity, out int seed)
    {
        numberOfItems = 0;
        capacity = 0;
        seed = 0;

        ResetValidationState();
        var isValid = true;

        if (!int.TryParse(txtNumberOfItems.Text, out numberOfItems) || numberOfItems <= 0)
        {
            MarkInvalid(txtNumberOfItems);
            isValid = false;
        }

        if (!int.TryParse(txtCapacity.Text, out capacity) || capacity < 0)
        {
            MarkInvalid(txtCapacity);
            isValid = false;
        }

        if (!int.TryParse(txtSeed.Text, out seed))
        {
            MarkInvalid(txtSeed);
            isValid = false;
        }

        if (isValid)
        {
            return true;
        }

        MessageBox.Show(
            "Popraw podswietlone pola: Number of items > 0, Capacity >= 0, Seed jako liczba calkowita.",
            "Bledne dane",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
        return false;
    }


    private void button1_Click_1(object sender, EventArgs e)
    {
        if (!TryReadInputs(out var numberOfItems, out var capacity, out var seed))
        {
            return;
        }

        var problem = new Problem(numberOfItems, seed);
        var items = problem.GenerateItems();
        var selectedItems = problem.Solve(items, capacity);

        txtData.Text = string.Join(Environment.NewLine, items.Select(i => i.ToString()));

        var selectedText = string.Join(Environment.NewLine, selectedItems.Select(i => i.ToString()));
        var totalWeight = selectedItems.Sum(i => i.Weight);
        var totalValue = selectedItems.Sum(i => i.Value);

        txtResults.Text = string.IsNullOrWhiteSpace(selectedText)
            ? "Brak elementow mieszcacych sie w plecaku."
            : $"{selectedText}{Environment.NewLine}{Environment.NewLine}Suma Weight: {totalWeight}{Environment.NewLine}Suma Value: {totalValue}";
    }
}