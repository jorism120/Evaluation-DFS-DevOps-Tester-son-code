using EvaluationSampleCode;

namespace EvaluationSampleCodeUnitsTests;

[TestClass]
public class ReservationUnitsTests
{
    
    
    private Reservation _reservation;
    public User _madeBy;
    
    [TestInitialize]
    public void Initialize()
    {
        _reservation = new Reservation(_madeBy);
    }
    
    [TestMethod]
    public void CanBeCancelledBy_VerifyCanBeCancelledBy_Cancelled()
    {
        _madeBy = new User();
        _madeBy.IsAdmin = true;
        _reservation = new Reservation(_madeBy);
        Assert.IsTrue(_reservation.CanBeCancelledBy(_madeBy));
    }

    
}