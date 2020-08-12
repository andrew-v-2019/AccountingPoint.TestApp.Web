
<template>
  <div class="buttons-page-container">
    <div class="buttons-container">
      <button
        type="button"
        class="btn btn-danger"
        v-on:click="onClick(btn)"
        v-for="btn in buttons"
        :key="btn.id"
      >{{ btn.title }}</button>

      <label v-if="currentButton">Текущая кнопка: {{currentButton.id}}</label>
    </div>

    <template v-for="btn in buttons">
      <button-view
        :key="btn.id"
        v-show="isCurrentButton(btn)"
        v-if="hasBeenClicked(btn)"
        :button="btn"
      ></button-view>
    </template>
  </div>
</template>

<script>
/**Страница для отображения кнопок и View для каждой из кнопок */
export default {
  props: {
    buttonsCount: {
      type: Number,
    },
  },
  data: function () {
    return {
      buttons: [],
      currentButton: null,
      clickedButtons: [],
    };
  },
  created: function () {
    this.fillButtons();
    if (!this.buttons.length) {
      return;
    }
    this.onClick(this.buttons[0]);
  },

  methods: {
    /**
     *@description Проверка: нажималась ли кнопка ранее
     *@param {Object} button Объект кнопки
     */
    hasBeenClicked(button) {
      const clicked = this.clickedButtons.find((b) => b.id === button.id);
      return clicked;
    },

    /**
     *@description Проверка: является ли кнопка текущей нажатой
     *@param {Object} button Объект кнопки
     */
    isCurrentButton(button) {
      return this.currentButton.id === button.id;
    },

    /**
     *@description Обработчик нажатия на кнопку
     *@param {Object} button Объект кнопки
     */
    onClick(button) {
      this.currentButton = button;
      this.clickedButtons.push(button);
    },

    /**
     *@description Заролняет массив с кнопками в зависимости от переданного buttonsCount
     */
    fillButtons: function () {
      for (let i = 1; i <= this.buttonsCount; i++) {
        const btn = {
          id: i,
          title: "Кнопка " + i,
          title2: "кнопки " + i,
          delaySeconds: this.getRandomInt(3),
        };

        this.buttons.push(btn);
      }
    },
    /**
     *@description Возвращает случайное значение в диапазоне [0..max]
     *@param {Number} max Максимальное значение
     */
    getRandomInt: function (max) {
      return Math.floor(Math.random() * Math.floor(max));
    },
  },
};
</script>




