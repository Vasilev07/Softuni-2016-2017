function countOccurences(input) {
      let word = input[0]   ;
      let text = input[1];
      let index = text.indexOf(word);
      let occurance = 0;
    while (index > -1){
        occurance++;
        index = text.indexOf(word, index + 1);
    }
    console.log(occurance);
}
countOccurences(['the', 'The quick brown fox jumps over the lay dog.']);
countOccurences(['ma', 'Marine mammal training is the training and caring for marine life such as, dolphins, killer whales, sea lions, walruses, and other marine mammals. It is also a duty of the trainer to do mental and physical exercises to keep the animal healthy and happy.']);