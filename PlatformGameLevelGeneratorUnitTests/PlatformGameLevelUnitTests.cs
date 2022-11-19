using PlatformGameLevelGeneratorCore;

namespace PlatformGameLevelGeneratorUnitTests;

public class PlatformGameLevelUnitTests
{
    private int _length { get; set; }
    private PlatformGameLevel _level { get; set; }
    
    [SetUp]
    public void Setup()
    {
        _length = 10;
        _level = new PlatformGameLevel(_length);
    }
    
    [Test]
    public void IsLengthCalculatedCorrectly()
    {
        Assert.That(_level, Has.Length.EqualTo(_length));
    }
    
    [Test]
    public void IsLevelAnIEnumerable()
    {
        var map = _level.Map;
        Assert.IsInstanceOf<IEnumerable<Tile>>(map);
    }
    
    [Test]
    public void IsLevelLengthCorrect()
    {
        var map = _level.Map;
        Assert.That(_level, Has.Length.EqualTo(map.Count));
    }
    
    [Test]
    public void IsFirstTileAStartTile()
    {
        Assert.AreEqual(_level.Map.First.ValueRef.Texture, 'S');
    }
    
    [Test]
    public void IsLastTileAFinishTile()
    {
        Assert.AreEqual(_level.Map.Last.ValueRef.Texture, 'F');
    }
}