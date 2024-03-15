import logo from './bowlingLogo.avif';

function Header() {
  return (
    <header className="row header navbar navbar-dark ">
      <div className="col-4">
        <img
          src={logo}
          className="logo"
          alt="logo"
          style={{ width: '200px' }}
        />
      </div>
      <h1 className="col subtitle">
        Bowling is making a come back! See below for the best bowlers to place
        your bets
      </h1>
    </header>
  );
}

export default Header;
