const gameStart = document.querySelector('.game-start');
const gameScore = document.querySelector('.game-score');
const gamePoints = document.querySelector('.points');
const gameArea = document.querySelector('.game-area');
const gameOver = document.querySelector('.game-over');

gameStart.addEventListener('click', onGameStart);

//Global vars
let keys = {};
let player = {
    x: 150,
    y: 100,
    width: 0,
    height: 0,
    lastTimeFiredFireball: 0
};
let game = {
    speed: 2,
    movingMultiplier: 4,
    fireBallMultiplier: 5,
    fireInterval: 1000,
    cloudSpawnInterval: 3000,
    bugSpawnInterval: 1000,
    bugKillBonus: 2000
};
let scene = {
    score: 0,
    lastCloudSpawn: 0,
    lastBugSpawn: 0,
    isActiveGame: true 
};

function onGameStart(e) {
    gameStart.classList.add('hide');
    //render wizard
    const wizard = document.createElement('div');
    wizard.classList.add('wizard');
    wizard.style.top = player.y + 'px';
    wizard.style.left = player.x + 'px';
    gameArea.appendChild(wizard);
    player.width = wizard.offsetWidth;
    player.height = wizard.offsetHeight;
    //game infinite loop
    window.requestAnimationFrame(gameAction);

}

document.addEventListener('keydown', onKeyDown);
document.addEventListener('keyup', onKeyUp);

function onKeyDown(e) {
    keys[e.code] = true;
    console.log(keys);
}
function onKeyUp(e) {
    keys[e.code] = false;
    console.log(keys);
}

//game loop func
function gameAction(timestamp) {

    const wizard = document.querySelector('.wizard');
    //Apply gravity
    let isInAir = (player.y + player.height) <= gameArea.offsetHeight;
    if (isInAir) {
        player.y += game.speed;
    }

    //Add bugs
    if (timestamp - scene.lastBugSpawn > game.bugSpawnInterval + 5000 * Math.random()) {
        let bug = document.createElement('div');
        bug.classList.add('bug');
        bug.x = gameArea.offsetWidth - 60;
        bug.style.left = bug.x + 'px';
        bug.style.top = (gameArea.offsetHeight - 60) * Math.random() + 'px';
        gameArea.appendChild(bug);
        scene.lastBugSpawn = timestamp;
    }

    //Modify bug position 
    let bugs = Array.from(document.querySelectorAll('.bug'));
    bugs.forEach(bug => {
        bug.x -= game.speed * 3;
        bug.style.left = bug.x + 'px';
        if (bug.x + bug.offsetWidth <= 0) {
            bug.remove();
        }
    })

    
    //Modify fireBalls positions
    let fireBalls = Array.from(document.querySelectorAll('.fire-ball'));
    fireBalls.forEach(fireBall => {
        fireBall.x += game.speed * game.fireBallMultiplier;
        fireBall.style.left = fireBall.x + 'px';
        if (fireBall.x + fireBall.offsetWidth > gameArea.offsetWidth) {
            fireBall.remove();
        }
    });

    //Increase Score
    scene.score++;

    //Register user input
    if (keys.ArrowUp && player.y > 0) {
        player.y -= game.speed * game.movingMultiplier;
    }
    if (keys.ArrowDown && isInAir) {
        player.y += game.speed * game.movingMultiplier;
    }
    if (keys.ArrowLeft && player.x > 0) {
        player.x -= game.speed * game.movingMultiplier;
    }
    if (keys.ArrowRight && player.x + player.width < gameArea.offsetWidth) {
        player.x += game.speed * game.movingMultiplier;
    }
    if (keys.Space && timestamp - player.lastTimeFiredFireball > game.fireInterval) {
        wizard.classList.add('wizard-fire');
        addFireBall(player);
        player.lastTimeFiredFireball = timestamp;
    }
    else {
        wizard.classList.remove('wizard-fire');
    }

    wizard.style.top = player.y + 'px';
    wizard.style.left = player.x + 'px';

    //Detect collision
    bugs.forEach(bug => {
        if (isCollision(wizard, bug)) {
            gameOverAction();
        }
        fireBalls.forEach(fball=>{
            if (isCollision(fball, bug)) {
                scene.score += game.bugKillBonus;
                fball.remove();
                bug.remove();
            }
        })
    })

    //Apply score
    gamePoints.textContent = scene.score + ' pts.';



    //Add Clouds
    if (timestamp - scene.lastCloudSpawn > game.cloudSpawnInterval + 20000 * Math.random()) {

        let cloud = document.createElement('div');
        cloud.classList.add('cloud');
        cloud.x = gameArea.offsetWidth - 200;
        cloud.style.left = cloud.x + 'px';
        cloud.style.top = (gameArea.offsetHeight - 200) * Math.random() + 'px';
        scene.lastCloudSpawn = timestamp;

        gameArea.appendChild(cloud);
    }

    //Modify cloud position. 
    let clouds = Array.from(document.querySelectorAll('.cloud'));
    clouds.forEach(cloud => {
        cloud.x -= game.speed;
        cloud.style.left = cloud.x + 'px';

        if (cloud.x + clouds.offsetWidth <= 0) {
            cloud.remove();
        }

    });

    //Loop
    if (scene.isActiveGame) {
        window.requestAnimationFrame(gameAction);
    }
}

function addFireBall(player) {
    let fireBall = document.createElement('div');

    fireBall.classList.add('fire-ball');
    fireBall.style.top = (player.y + player.height / 3 - 5) + 'px';
    fireBall.x = player.x + player.width;
    fireBall.style.left = fireBall.x + 'px';


    gameArea.appendChild(fireBall);
}

function isCollision(firstElement, secondElement) {
    let firstRect = firstElement.getBoundingClientRect();
    let secondRect = secondElement.getBoundingClientRect();

    return !(firstRect.top > secondRect.bottom ||
        firstRect.bottom < secondRect.top ||
        firstRect.left > secondRect.right ||
        firstRect.right < secondRect.left);
}

function gameOverAction(){
    scene.isActiveGame = false;
    gameOver.classList.remove('hide');
}

