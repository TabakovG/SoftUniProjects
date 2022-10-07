function solution(arg) {
  let post = this;
  let engine = {
    upvote: function () { post.upvotes++; },
    downvote: function () { post.downvotes++; },
    score: function () {
      let adjust = 0;
      post.upvotes + post.downvotes > 50 ?
        post.upvotes > post.downvotes ?
          adjust += Number(Math.ceil(post.upvotes * 0.25)) :
          adjust += Number(Math.ceil(post.downvotes * 0.25)) :
        adjust = 0;

      let reportUp = post.upvotes + adjust;
      let reportDown = post.downvotes + adjust;
      let balance = reportUp - reportDown;

      let rating = '';
      if (post.upvotes - post.downvotes >= 0) {
        if (post.upvotes / (post.upvotes + post.downvotes) > 0.66) {
          rating = 'hot';
        }
        else {
          rating = post.upvotes + post.downvotes > 100 ? 'controversial' : 'new';
        }
      }
      else {
        rating = 'unpopular';
      }
      rating = post.upvotes + post.downvotes < 10 ? 'new': rating;
      return [reportUp, reportDown, balance, rating]
    }
  }
  return engine[arg]();
}



// let post = {
//   id: '3',
//   author: 'emil',
//   content: 'wazaaaaa',
//   upvotes: 100,
//   downvotes: 100
// };
// solution.call(post, 'upvote');
// solution.call(post, 'downvote');
// let score = solution.call(post, 'score');
// console.log(score); // [127, 127, 0, 'controversial']
// for (let index = 0; index < 50; index++) {
//   solution.call(post, 'downvote');         // (executed 50 times)
// }
// score = solution.call(post, 'score');     // [139, 189, -50, 'unpopular']
// console.log(score);

var forumPost = {
  id: '2',
  author: 'gosho',
  content: 'whats up?',
  upvotes: 120,
  downvotes: 30
};
console.log(solution.call(forumPost, 'score'));
