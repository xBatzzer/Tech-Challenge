using NUnit.Framework;

public class ModelTest
{

    [Test] 
    public void salaryIncrementArtist()
    {
        var artist = new Artist();

        float incrementSalary = artist.salaryIncrement();

        Assert.AreEqual(incrementSalary, artist.Salary);
    }

    [Test]
    public void salaryIncrementPM()
    {
        var PM = new ProjectManager(EnumSeniority.Senior);

        float incrementSalary = PM.salaryIncrement();

        Assert.AreEqual(incrementSalary, PM.Salary);
    }

    [Test]
    public void salaryIncrementEngineering()
    {
        var engineering = new Engineering(EnumSeniority.Senior);

        float incrementSalary = engineering.salaryIncrement();

        Assert.AreEqual(incrementSalary, engineering.Salary);
    }

    [Test]
    public void salaryIncrementCeo()
    {
        var ceo = new Ceo(EnumSeniority.Senior);

        float incrementSalary = ceo.salaryIncrement();

        Assert.AreEqual(incrementSalary, ceo.Salary);
    }

    [Test]
    public void salaryIncrementDesign()
    {
        var design = new Design(EnumSeniority.Senior);

        float incrementSalary = design.salaryIncrement();

        Assert.AreEqual(incrementSalary, design.Salary);
    }

}
